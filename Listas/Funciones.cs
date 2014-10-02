using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using CapaConexion;
namespace Listas
{
    class Funciones
    {
        #region "FUNCIONES LISTA OFAC"
        public static DateTime readOFACPublish_Date(string urlOfac)
        {
            List<IbsStructure> ibsList = new List<IbsStructure>();
            CapaConexion.Conexion conn = new CapaConexion.Conexion();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(urlOfac);
            XmlNodeList publishdate = xDoc.GetElementsByTagName("publshInformation");
            foreach (XmlElement nodo in publishdate)
            {
                var mm = nodo.GetElementsByTagName("Publish_Date")[0].InnerText.Substring(0,2);
                var dd = nodo.GetElementsByTagName("Publish_Date")[0].InnerText.Substring(3,2);
                var yyyy = nodo.GetElementsByTagName("Publish_Date")[0].InnerText.Substring(6, 4);
                return    Convert.ToDateTime(dd+"/"+mm+"/"+yyyy);            
            }
            return new DateTime();
        }

        public static List<IbsStructure> readOFACList(string urlOfac)
        {
            List<IbsStructure> ibsList = new List<IbsStructure>();
            CapaConexion.Conexion conn = new CapaConexion.Conexion();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(urlOfac);
            XmlNodeList personas = xDoc.GetElementsByTagName("sdnEntry");
            foreach (XmlElement nodo in personas)
            {
                IbsStructure ibsEstructure = new IbsStructure();
                ibsEstructure.fuente = "OFAC";
                ibsEstructure.codigo = Convert.ToInt32(nodo.GetElementsByTagName("uid")[0].InnerText);
                ibsEstructure.tipoPersona = nodo.GetElementsByTagName("sdnType")[0].InnerText == "Individual" ? TipoPersona.N : TipoPersona.J;
                XmlNodeList listasCausales = nodo.GetElementsByTagName("program");
                foreach (XmlElement nodoCausal in listasCausales)
                {
                    Object causalIBS = conn.DevolverDato("get_causalIBS", new String[] { "pnombre", "pfuente" }, new Object[] { nodoCausal.InnerText, "OFAC" });
                    if (causalIBS != null)
                    {
                        ibsEstructure.causales.Add((string)causalIBS);
                    }
                    else
                    {
                        throw new Exception("No se puede homologar la causal " + nodoCausal.InnerText);
                    }
                }
                if (ibsEstructure.tipoPersona == TipoPersona.J)
                {
                    ibsEstructure.nombreCompleto = nodo.GetElementsByTagName("lastName")[0].InnerText;
                }
                else
                {
                    ibsEstructure.apellidos = nodo.GetElementsByTagName("lastName")[0].InnerText;
                    if (nodo.GetElementsByTagName("firstName").Count > 0)
                    {
                        ibsEstructure.nombres = nodo.GetElementsByTagName("firstName")[0].InnerText;
                    }
                }
                if (nodo.GetElementsByTagName("dateOfBirthItem").Count > 0)
                {
                    var dateOfBirthItem = nodo.GetElementsByTagName("dateOfBirthItem")[0].InnerText;
                }
                XmlNodeList listaIDS = nodo.GetElementsByTagName("id");
                foreach (XmlElement nodoID in listaIDS)
                {
                    Object idIBS = conn.DevolverDato("get_tipoid", new String[] { "pnombre", "pfuente" },
                                new Object[] { nodoID.GetElementsByTagName("idType")[0].InnerText, "OFAC" });
                    if (idIBS != null)
                    {
                        ibsEstructure.identificaciones.Add(new IbsStructure.Identificacion((string)idIBS, nodoID.GetElementsByTagName("idNumber")[0].InnerText));
                    }
                    else
                    {
                        throw new Exception("No se puede homologar el tipo de identificación " + nodo.GetElementsByTagName("idType")[0].InnerText);
                    }
                }
                XmlNodeList listasAddress = nodo.GetElementsByTagName("address");
                if (listasAddress.Count > 0)
                {
                    XmlNodeList countries = ((XmlElement)listasAddress[0]).GetElementsByTagName("country");
                    if (countries.Count > 0)
                    {
                        ibsEstructure.pais = (string)conn.DevolverDato("get_paises",
                            new String[] { "pnombre", "pfuente" },
                                new Object[] { countries[0].InnerText, "OFAC" });

                        if (ibsEstructure.pais == null)
                        {
                            throw new Exception("No se puede homologar el pais " + countries[0].InnerText);
                        }
                    }
                    XmlNodeList address1s = ((XmlElement)listasAddress[0]).GetElementsByTagName("address1");
                    if (address1s.Count > 0)
                    {
                        ibsEstructure.direccion1 = address1s[0].InnerText;
                    }
                    XmlNodeList address2s = ((XmlElement)listasAddress[0]).GetElementsByTagName("address2");
                    if (address2s.Count > 0)
                    {
                        ibsEstructure.direccion2 = address2s[0].InnerText;
                    }
                    XmlNodeList address3s = ((XmlElement)listasAddress[0]).GetElementsByTagName("address3");
                    if (address3s.Count > 0)
                    {
                        ibsEstructure.direccion3 = address3s[0].InnerText;
                    }
                }
                XmlNodeList listaFechasNacimiento = nodo.GetElementsByTagName("dateOfBirth");
                if (listaFechasNacimiento.Count > 0)
                {
                    listaFechasNacimiento[0].InnerText.Replace("circa ", "");
                    if (listaFechasNacimiento[0].InnerText.Length == 4)
                    {
                        ibsEstructure.fechaNacimiento = Convert.ToDateTime("01 Jan " + listaFechasNacimiento[0].InnerText);
                    }
                    else if (listaFechasNacimiento[0].InnerText.Length == 8)
                    {
                        ibsEstructure.fechaNacimiento = Convert.ToDateTime("01 " + listaFechasNacimiento[0].InnerText);
                    }
                    else if (listaFechasNacimiento[0].InnerText.Length == 11)
                    {
                        ibsEstructure.fechaNacimiento = Convert.ToDateTime(listaFechasNacimiento[0].InnerText);
                    }
                }

                if (ibsEstructure.identificaciones.Count == 0)
                {
                    ibsEstructure.identificaciones.Add(new IbsStructure.Identificacion(null, null));
                }

                ibsList.Add(ibsEstructure);
            }

            return ibsList;
        }
        #endregion

        #region  "FUNCIONES LISTA ONU"

        public static DateTime readONUPublish_Date(string urlOfac)
        {
            List<IbsStructure> ibsList = new List<IbsStructure>();
            CapaConexion.Conexion conn = new CapaConexion.Conexion();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(urlOfac);
            XmlNode NodoPrincipal = xDoc.GetElementsByTagName("CONSOLIDATED_LIST")[0];
            DateTime publishdate = Convert.ToDateTime(NodoPrincipal.Attributes["dateGenerated"].Value);                
            return publishdate;
        }


        public static List<IbsStructure> readIbsFromOnuList(string urlOnu)
        {
            List<IbsStructure> ibsList = new List<IbsStructure>();
            CapaConexion.Conexion conn = new CapaConexion.Conexion();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(urlOnu);
            /* IDIVIDUOS*/
            XmlNodeList personas = xDoc.GetElementsByTagName("INDIVIDUAL");
            foreach (XmlElement nodo in personas)
            {
                IbsStructure ibsEstructura = new IbsStructure();
                ibsEstructura.fuente = "ONU";
                ibsEstructura.tipoPersona = TipoPersona.N;
                XmlNodeList xmllistaCausales = nodo.GetElementsByTagName("LIST_TYPE");
                foreach (XmlElement nd in xmllistaCausales)
                {                    
                    Object causalIBS = conn.DevolverDato("get_causalesIBS", new String[] { "pnombre", "pfuente" }, new Object[] { nd.GetElementsByTagName("VALUE")[0].InnerText, "ONU" });
                    if (causalIBS != null)
                    {
                        ibsEstructura.causales.Add(causalIBS.ToString());
                    }
                    else
                    {
                        throw new Exception("No se puede homologar la causal " + nd.GetElementsByTagName("VALUE")[0].InnerText);
                    }
                }
                XmlNodeList xmllistaDocumentos = nodo.GetElementsByTagName("INDIVIDUAL_DOCUMENT");
                foreach (XmlElement nd in xmllistaDocumentos)
                {
                    if (nd.GetElementsByTagName("TYPE_OF_DOCUMENT").Count > 0 && nd.GetElementsByTagName("NUMBER").Count > 0)
                    {
                        var tipo = conn.DevolverDato("get_tipoid", new String[] { "pnombre", "pfuente" }, new Object[] { nd.GetElementsByTagName("TYPE_OF_DOCUMENT")[0].InnerText, "ONU" });
                        if (tipo != null)
                        {
                            var numero = nd.GetElementsByTagName("NUMBER")[0].InnerText;
                            ibsEstructura.identificaciones.Add(new IbsStructure.Identificacion((String)tipo, numero));
                        }
                        else
                        {
                            throw new Exception("No se puede homologar el tipo de identificación " + nd.GetElementsByTagName("TYPE_OF_DOCUMENT")[0].InnerText);
                        }
                    }
                }

                ibsEstructura.fechaInclusion = Convert.ToDateTime(nodo.GetElementsByTagName("LISTED_ON")[0].InnerText);
                ibsEstructura.codigo = Convert.ToInt32(nodo.GetElementsByTagName("DATAID")[0].InnerText);
                ibsEstructura.genero = " ";
                ibsEstructura.nombres = nodo.GetElementsByTagName("FIRST_NAME")[0].InnerText;
                XmlNodeList g = nodo.GetElementsByTagName("INDIVIDUAL_DATE_OF_BIRTH");
                foreach (XmlElement item in g)
                {
                    if (item.GetElementsByTagName("DATE").Count > 0)
                    {
                        ibsEstructura.fechaNacimiento = Convert.ToDateTime(item.GetElementsByTagName("DATE")[0].InnerText);
                    }
                    else if (item.GetElementsByTagName("YEAR").Count > 0)
                    {
                        ibsEstructura.fechaNacimiento = Convert.ToDateTime("01 Jan " + item.GetElementsByTagName("YEAR")[0].InnerText);
                    }
                   
                }
                ibsEstructura.nombres = nodo.GetElementsByTagName("FIRST_NAME")[0].InnerText;
                if (nodo.GetElementsByTagName("SECOND_NAME").Count > 0) ibsEstructura.nombres += " " + nodo.GetElementsByTagName("SECOND_NAME")[0].InnerText;
                if (nodo.GetElementsByTagName("THIRD_NAME").Count > 0) ibsEstructura.apellidos = nodo.GetElementsByTagName("THIRD_NAME")[0].InnerText;
                if (nodo.GetElementsByTagName("FOURTH_NAME").Count > 0) ibsEstructura.apellidos += " " + nodo.GetElementsByTagName("FOURTH_NAME")[0].InnerText;

                XmlNodeList adressList = nodo.GetElementsByTagName("INDIVIDUAL_ADDRESS");
                foreach (XmlElement item in adressList)
                {
                    if (item.GetElementsByTagName("CITY").Count > 0) ibsEstructura.direccion1 = item.GetElementsByTagName("CITY")[0].InnerText;
                    if (item.GetElementsByTagName("STATE_PROVINCE").Count > 0) ibsEstructura.direccion1 += ", " + item.GetElementsByTagName("STATE_PROVINCE")[0].InnerText;
                    if (item.GetElementsByTagName("STREET").Count > 0) ibsEstructura.direccion2 = item.GetElementsByTagName("STREET")[0].InnerText;

                    if (item.GetElementsByTagName("COUNTRY").Count > 0)
                    {

                        ibsEstructura.pais = (string)conn.DevolverDato("get_paises", new String[] { "pnombre", "pfuente" }, new Object[] { item.GetElementsByTagName("COUNTRY")[0].InnerText, "ONU" });
                        if (ibsEstructura.pais == null)
                        {
                            throw new Exception("No se puede homologar el pais " + item.GetElementsByTagName("COUNTRY")[0].InnerText);
                        }
                    }
                }

                if (ibsEstructura.identificaciones.Count == 0)
                {
                    ibsEstructura.identificaciones.Add(new IbsStructure.Identificacion(null, null));
                }


                ibsList.Add(ibsEstructura);
            }

             /* IDIVIDUOS*/
            XmlNodeList entidades = xDoc.GetElementsByTagName("ENTITY");
            foreach (XmlElement nodo in entidades)
            {
              IbsStructure ibsEstructura= new IbsStructure();

                ibsEstructura.fechaInclusion = Convert.ToDateTime(nodo.GetElementsByTagName("LISTED_ON")[0].InnerText);
                ibsEstructura.nombreCompleto = nodo.GetElementsByTagName("FIRST_NAME")[0].InnerText;                
                ibsEstructura.codigo = Convert.ToInt32(nodo.GetElementsByTagName("DATAID")[0].InnerText);
                ibsEstructura.tipoPersona = TipoPersona.J;
                ibsEstructura.genero = " ";
                ibsEstructura.nombres = null;
                ibsEstructura.apellidos = null;
                ibsEstructura.identificaciones.Add(new IbsStructure.Identificacion(null, null));
                ibsEstructura.departamento = null;
                ibsEstructura.fechaNacimiento = null;
                ibsEstructura.fechaInclusion = Convert.ToDateTime(nodo.GetElementsByTagName("LISTED_ON")[0].InnerText);
                ibsEstructura.fuente = "ONU";



                XmlNodeList adressList = nodo.GetElementsByTagName("ENTITY_ADDRESS");
                foreach (XmlElement item in adressList)
                {
                    if (item.GetElementsByTagName("CITY").Count > 0) ibsEstructura.direccion1 = item.GetElementsByTagName("CITY")[0].InnerText;
                    if (item.GetElementsByTagName("STATE_PROVINCE").Count > 0) ibsEstructura.direccion1 += ", " + item.GetElementsByTagName("STATE_PROVINCE")[0].InnerText;
                    if (item.GetElementsByTagName("STREET").Count > 0) ibsEstructura.direccion2 = item.GetElementsByTagName("STREET")[0].InnerText;

                    if (item.GetElementsByTagName("COUNTRY").Count > 0)
                    {

                        ibsEstructura.pais = (string)conn.DevolverDato("get_paises", new String[] { "pnombre", "pfuente" }, new Object[] { item.GetElementsByTagName("COUNTRY")[0].InnerText, "ONU" });
                        if (ibsEstructura.pais == null)
                        {
                            throw new Exception("No se puede homologar el pais " + item.GetElementsByTagName("COUNTRY")[0].InnerText);
                        }
                    }
                }

                XmlNodeList g = nodo.GetElementsByTagName("INDIVIDUAL_DATE_OF_BIRTH");
                foreach (XmlElement item in g)
                {
                    if (item.GetElementsByTagName("DATE").Count > 0)
                    {
                        ibsEstructura.fechaNacimiento = Convert.ToDateTime(item.GetElementsByTagName("DATE")[0].InnerText);
                    }
                    else if (item.GetElementsByTagName("YEAR").Count > 0)
                    {
                        ibsEstructura.fechaNacimiento = Convert.ToDateTime("01 Jan " + item.GetElementsByTagName("YEAR")[0].InnerText);
                    }

                }

                XmlNodeList xmllistaCausales = nodo.GetElementsByTagName("LIST_TYPE");
                foreach (XmlElement nd in xmllistaCausales)
                {
                    Object causalIBS = conn.DevolverDato("get_causalesIBS", new String[] { "pnombre", "pfuente" }, new Object[] { nd.GetElementsByTagName("VALUE")[0].InnerText, "ONU" });
                    if (causalIBS != null)
                    {
                        ibsEstructura.causales.Add(causalIBS.ToString());
                    }
                    else
                    {
                        throw new Exception("No se puede homologar la causal " + nd.GetElementsByTagName("VALUE")[0].InnerText);
                    }
                }
                ibsList.Add(ibsEstructura);
            }


            return ibsList;
        }

        #endregion

        #region FUNCIONES GENERALES

        public static List<Fuente> getFuentes() {
            DataTable dt = new CapaConexion.Conexion().DevolverDatosDirecto("fuentes");
             List<Fuente> lista =( from s in dt.AsEnumerable()
                      select new Fuente
                      {
                          fecha =Convert.ToDateTime( s["ultimapublicacion"]),
                          codigo =Convert.ToString( s["codigo"]),
                          nombre = Convert.ToString(s["nombre"]),
                          seleccionado = false
                      }).ToList();
             return lista;
        }

        public static List<NovedadCompilado> get_ResumenLista(String Fuente)
        {
            DataTable dt = new CapaConexion.Conexion().DevolverDatos("get_ResumenLista","pCodFuente",Fuente);
            List<NovedadCompilado> lista = (from s in dt.AsEnumerable()
                                            select new NovedadCompilado
                      {
                          novedad =Convert.ToString( s["novedad"]),
                          cantidad =Convert.ToInt32( s["cantidad"])                          
                      }).ToList();
             return lista;
        }

        public static List<IbsStructurePlana> get_ListaActual()
        {
            DataTable dt = new CapaConexion.Conexion().DevolverDatosDirecto("vst_listaactual");
            List<IbsStructurePlana> lista = (from s in dt.AsEnumerable()
                                             select new IbsStructurePlana
                                            {
                                                apellidos = Convert.ToString(s["apellidos"]),
                                                nombres = Convert.ToString(s["nombres"]),
                                                nombreCompleto = Convert.ToString(s["nombrecompleto"]),
                                                causal = Convert.ToString(s["Causal"]),
                                                codigo = Convert.ToInt32(s["codigoA"]),
                                                departamento = Convert.ToString(s["departamento"]),
                                                direccion1 = Convert.ToString(s["direccion1"]),
                                                direccion2 = Convert.ToString(s["direccion2"]),
                                                direccion3 = Convert.ToString(s["direccion3"]),
                                                fechaInclusion = Convert.ToDateTime(s["fechainclusion"]),
                                                fechaNacimiento = Convert.ToDateTime(s["fechaNacimiento"] == DBNull.Value ? null : s["fechaNacimiento"]),
                                                fuente = Convert.ToString(s["codFuente"]),
                                                numID = s["identificacion"] == DBNull.Value ? null : Convert.ToString(s["identificacion"]),
                                                tipoID = s["tipoID"] == DBNull.Value ? null : Convert.ToString(s["tipoID"]),
                                                pais = s["pais"] == DBNull.Value ? null : Convert.ToString(s["pais"]),
                                                tipoPersona = Convert.ToString(s["tipoPersona"]) == "J" ? TipoPersona.J : TipoPersona.N
                                            }).ToList();
            return lista;
        }

      
        public static Boolean saveList(List<IbsStructurePlana> Lista,DateTime fechaLista , String Fuente )
        {
            Conexion con = new Conexion();
            con.iniciarTransaccion();
            try
            {
                con.EjecutarProcedimientoTransaccion("del_ListaInactivas", new String[] { "pCodFuente" }, new String[] { Fuente });               
                con.EjecutarProcedimientoTransaccion("edit_UltimaPublicada", new String[] { "pcodigo", "pfecha" }, new Object[] { Fuente, fechaLista });
                foreach (var item in Lista)
                {
                    Object i = con.DevolverDatoTransaccion("get_NovedadIdividuo",
                                        new String[] { "pCodigo", "pTipoID", "pIdentificacion", "pCausal", "pCodFuente" },
                                        new Object[] { item.codigo, item.tipoID, item.numID, item.causal, Fuente});
                    if (i == null)
                    {  // toca agregarlo a la lista  y marcarlo como I
                        var X = item.tipoPersona.ToString();
                        con.EjecutarProcedimientoTransaccion("add_individuo",
                                                new String[] { "pcodigo", "pcausal", "ptipoID", "pidentificacion", "pnombreCompleto", "pnombres", "papellidos", "ptipopersona", "ppais", "pdepartamento", "pdireccion1", "pdireccion2", "pdireccion3", "pfechanacimiento","pfechaInclusion", "pCodFuente" },
                                                new Object[] { item.codigo, item.causal, item.tipoID, item.numID, item.nombreCompleto, item.nombres, item.apellidos, item.tipoPersona.ToString(), item.pais, item.departamento, item.direccion1, item.direccion2, item.direccion3, item.fechaNacimiento,item.fechaInclusion,Fuente });
                    }
                    else if ((string)i == "I" || (string)i == "A" || (string)i == "N")
                    { // fue creado/actualizado la anterior vez ... asignarle A                         
                        con.EjecutarProcedimientoTransaccion("edit_individuo",
                                                 new String[] { "pcodigo", "pcausal", "ptipoID", "pidentificacion", "pnombreCompleto", "pnombres", "papellidos", "ptipopersona", "ppais", "pdepartamento", "pdireccion1", "pdireccion2", "pdireccion3", "pfechanacimiento","pfechaInclusion", "pCodFuente" },
                                                new Object[] { item.codigo, item.causal, item.tipoID, item.numID, item.nombreCompleto, item.nombres, item.apellidos, item.tipoPersona.ToString(), item.pais, item.departamento, item.direccion1, item.direccion2, item.direccion3, item.fechaNacimiento,item.fechaInclusion, Fuente });
                    }
                }
                var eliminados =   con.DevolverDatosTransaccion("get_ListaActivos", new String[] { "pCodFuente" }, new String[] { Fuente });
                foreach (System.Data.DataRow item in eliminados.Rows)
                {
                     try
                        {
                        int cod =Convert.ToInt32( item["codigo"].ToString());
                        var cau = DBNull.Value.Equals( item["causal"])? null: (string)item["causal"];
                        var tipoid = DBNull.Value.Equals(item["tipoid"]) ? null : (string)item["tipoid"];
                        var ident = DBNull.Value.Equals(item["identificacion"]) ? null : (string)item["identificacion"];                      
                        if (Lista.FirstOrDefault(a => a.codigo == cod && a.causal == cau && a.tipoID == tipoid && a.numID == ident) == null)
                        {
                            con.EjecutarProcedimientoTransaccion("edit_ListaEliminar", new String[] { "pid" }, new Object[] { item["id"] });
                        }
                        }
                        catch (Exception)
                        {
                            throw;
                        }                        
                }
                con.EjecutarProcedimientoTransaccion("add_SendDataToHistoricos", new String[] { "pCodFuente" }, new String[] { Fuente });                      
                con.finalizarTransaccion(true);
                return true;
            }
            catch (Exception)
            {
                con.finalizarTransaccion(false);
                throw;
            }                    
        }
        
        public static DateTime getLastChargedList(String codFuente){            
            Conexion con = new Conexion();
            return (DateTime) con.DevolverDato("get_UltimaPublicada", "pcodigo", codFuente);
        }

        public static List<IbsStructurePlana> converToPlain(List<IbsStructure> List)
        {
            var listaEnumerable = List.SelectMany(indi => indi.identificaciones,
                    (l, i) => new
                    {
                        l.apellidos,
                        l.causales,
                        l.codigo,
                        l.departamento,
                        l.direccion1,
                        l.direccion2,
                        l.direccion3,
                        l.fechaInclusion,
                        l.fechaNacimiento,
                        l.fuente,
                        l.nombreCompleto,
                        l.nombres,
                        l.Novedad,
                        l.pais,
                        l.tipoPersona,
                        numID = i.numero,
                        tipoID = i.tipo
                    }
                    ).Distinct().SelectMany(caus => caus.causales.Distinct(),
                    (l, i) => new IbsStructurePlana()
                    {
                        apellidos = l.apellidos,
                        causal = i,
                        codigo = l.codigo,
                        departamento = l.departamento,
                        direccion1 = l.direccion1,
                        direccion2 = l.direccion2,
                        direccion3 = l.direccion3,
                        fechaInclusion = l.fechaInclusion,
                        fechaNacimiento = l.fechaNacimiento,
                        fuente = l.fuente,                        
                        nombreCompleto = l.nombreCompleto,
                        nombres = l.nombres,
                        Novedad = l.Novedad,
                        pais = l.pais,
                        tipoPersona = l.tipoPersona,
                        numID = l.numID,
                        tipoID = l.tipoID
                    }
                    ).Distinct()
                    ;

            List<IbsStructurePlana> lst = new List<IbsStructurePlana>();
            lst = listaEnumerable.ToList();
            return lst;

        }        

        public static void generateFile(String UrlFile, List<String> Fuentes)
        {

            List<string> Lineas = new List<string>();

            foreach (var item in Fuentes)
            {
                var qry = (from itm in (new CapaConexion.Conexion().DevolverDatos("get_lista_Archivo", "pCodFuente", item).AsEnumerable())
                select  (String) itm["linea"]).ToList();
                Lineas.AddRange((List<string>) qry);
            }       
                System.IO.File.WriteAllLines(@UrlFile,Lineas.ToArray());     
        }

        public static void generateFileHistorico(String UrlFile, String  Fuente, DateTime FechaInicial, DateTime FechaFinal)
        {
            List<string> Lineas = new List<string>();

            var qry = (from itm in (new CapaConexion.Conexion().DevolverDatos("get_lista_historica_Archivo", new string[] { "pCodFuente","pFechaInicial","pFechaFinal" }, new Object[]{Fuente, FechaInicial, FechaFinal }).AsEnumerable())
                         select (String)itm["linea"]).ToList();
                Lineas.AddRange((List<string>)qry);
        
            System.IO.File.WriteAllLines(@UrlFile, Lineas.ToArray());
        }
/*
        public static List<IbsStructurePlana> get_listaActual(String Fuente)
        {
            DataTable dt = new CapaConexion.Conexion().DevolverDatos("get_listaActual", "pCodFuente", Fuente);
            List<IbsStructurePlana> lista = (from s in dt.AsEnumerable()
                                             select new IbsStructurePlana
                                            {
                                                apellidos = Convert.ToString(s["apellidos"]),
                                                nombres = Convert.ToString(s["nombres"]),
                                                nombreCompleto = Convert.ToString(s["nombreCompleto"]),
                                                fuente = Convert.ToString(s["codFuente"]),
                                               
                                            }).ToList();
            return lista;
        }
        */
#endregion
    }
}
