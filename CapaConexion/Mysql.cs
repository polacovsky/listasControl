using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace CapaConexion
{
    public class Mysql
    {
        public  MySqlConnection MyConexion;
        private MySqlTransaction trans;

        public Mysql()
        {
            MyConexion = new MySqlConnection(Conexion.CadenaConexion);
        }

        #region "MODELO CONECTADO"

         public  bool Conectar()
        {
          
            bool conected = false;

            MyConexion.Open();
            conected = true;
            return conected;
        }

        public  void Desconectar()
        {
            if (!(MyConexion.State == ConnectionState.Closed))
            {
                try
                {
                    MyConexion.Close();
                }
                catch
                {
                }
            }
        }
        #endregion

        #region "FUNCIONES DE LLENADO DE DATOS"


        public void iniciarTransaccion(){
            Conectar();
            trans = MyConexion.BeginTransaction();
        }

        public void  finalizarTransaccion( Boolean estado)
        {
            if (estado)
            {
              trans.Commit()  ;
            }
            else {
                trans.Rollback();
            }
            trans = null;
            Desconectar();
        }



        public  void Llenarcombos(string Procedimiento, ref ComboBox combo, string campodescripcion, string campovalor)
        {
            DataTable dt = new DataTable();

            try
            {
                MySqlCommand cmd = new MySqlCommand(Procedimiento, MyConexion);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                cmd.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
                Console.WriteLine();
                combo.DataSource = dt;
                combo.DisplayMember = campodescripcion;
                combo.ValueMember = campovalor;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public  void Llenarcombos(string Procedimiento, ref ComboBox combo, string campodescripcion, string campovalor, string FILTRO, object VALOR)
        {
            DataTable dt = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand(Procedimiento, MyConexion);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                cmd.CommandType =CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(FILTRO, VALOR);
                da.Fill(dt);
                Console.WriteLine();
                combo.DataSource = dt;
                combo.DisplayMember = campodescripcion;
                combo.ValueMember = campovalor;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public  void LlenarcombosYautocompletar(string Procedimiento, ref ComboBox combo, string campodescripcion, string campovalor)
        {
            DataTable dt = new DataTable();

            try
            {
                MySqlCommand cmd = new MySqlCommand(Procedimiento, MyConexion);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                cmd.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
                Console.WriteLine();
                combo.DataSource = dt;
                combo.DisplayMember = campodescripcion;
                combo.ValueMember = campovalor;
                AutocompletarCombo(dt, combo, campodescripcion);


            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public  void LlenarcombosYautocompletar(string Procedimiento, ref ComboBox combo, string campodescripcion, string campovalor, string pParam, int pID)
        {
            DataTable dt = new DataTable();

            try
            {
                MySqlCommand cmd = new MySqlCommand(Procedimiento, MyConexion);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                cmd.Parameters.AddWithValue(pParam, pID);
                cmd.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
                Console.WriteLine();
                combo.DataSource = dt;
                combo.DisplayMember = campodescripcion;
                combo.ValueMember = campovalor;
                AutocompletarCombo(dt, combo, campodescripcion);

            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();

            }
        }

        public  void LlenarcombosDirectoYautocompletar(string Tabla, ref ComboBox combo, string campodescripcion, string campovalor)
        {
            try
            {
                DataTable dt = new DataTable();

                dt.Clear();
                MySqlCommand cmd = new MySqlCommand("select * from " + Tabla, MyConexion);
                cmd.CommandType = CommandType.Text;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da = new MySqlDataAdapter(cmd);

                da.Fill(dt);
                Console.WriteLine();
                combo.DataSource = dt;
                combo.DisplayMember = campodescripcion;
                combo.ValueMember = campovalor;

                AutocompletarCombo(dt, combo, campodescripcion);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public  void Llenarcombos(string Procedimiento, ref DataGridViewComboBoxColumn combo, string campodescripcion, string campovalor)
        {
            DataTable dt = new DataTable();

            try
            {
                MySqlCommand cmd = new MySqlCommand(Procedimiento, MyConexion);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                cmd.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
                Console.WriteLine();
                combo.DataSource = dt;
                combo.DisplayMember = campodescripcion;
                combo.ValueMember = campovalor;

            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();

            }
        }

        public  void Llenarcombos(ref DataTable DT, ref MySqlDataAdapter DA, string Procedimiento, ref ComboBox combo, string campodescripcion, string campovalor)
        {
            try
            {
                DT.Clear();
                MySqlCommand cmd = new MySqlCommand(Procedimiento, MyConexion);
                DA = new MySqlDataAdapter(cmd);
                cmd.CommandType = CommandType.StoredProcedure;
                DA.Fill(DT);
                Console.WriteLine();
                combo.DataSource = DT;
                combo.DisplayMember = campodescripcion;
                combo.ValueMember = campovalor;
                combo.SelectedValue = 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
        }

        public  void Llenarcombos(ref DataTable DT, ref MySqlDataAdapter DA, string Procedimiento, ref ComboBox combo, string campodescripcion, string campovalor, string pParam, int pID)
        {
            try
            {
                DT.Clear();
                MySqlCommand cmd = new MySqlCommand(Procedimiento, MyConexion);
                DA = new MySqlDataAdapter(cmd);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(pParam, pID);
                DA.Fill(DT);
                Console.WriteLine();
                combo.DataSource = DT;
                combo.DisplayMember = campodescripcion;
                combo.ValueMember = campovalor;
                combo.SelectedValue = 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public  void LlenarcombosDirecto(string Tabla, ref ComboBox combo, string campodescripcion, string campovalor)
        {
            try
            {
                DataTable dt = new DataTable();

                dt.Clear();
                MySqlCommand cmd = new MySqlCommand("select * from " + Tabla, MyConexion);
                cmd.CommandType = CommandType.Text;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da = new MySqlDataAdapter(cmd);
                Desconectar();
                da.Fill(dt);
                Console.WriteLine();
                combo.DataSource = dt;
                combo.DisplayMember = campodescripcion;
                combo.ValueMember = campovalor;
                combo.SelectedValue = 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public  void LlenarcombosDirecto(string Tabla, ref DataGridViewComboBoxColumn combo, string campodescripcion, string campovalor)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Clear();
                MySqlCommand cmd = new MySqlCommand("select * from " + Tabla, MyConexion);
                cmd.CommandType = CommandType.Text;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                Console.WriteLine();
                combo.DataSource = dt;
                combo.DisplayMember = campodescripcion;
                combo.ValueMember = campovalor;

            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public  void LlenarcombosYDatatable(string Procedimiento, ref DataTable dt, ref ComboBox combo, string campodescripcion, string campovalor)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand(Procedimiento, MyConexion);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter p_refcursor = new MySqlParameter();
                da.Fill(dt);
                Console.WriteLine();
                combo.DataSource = dt;
                combo.DisplayMember = campodescripcion;
                combo.ValueMember = campovalor;
                combo.SelectedValue = 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public  void RelacionarDosCombos(ref DataTable DT, ref MySqlDataAdapter DA, string ProcedPadre, string ProcedHijo, ref ComboBox cmboxpadre, ref ComboBox cmboxhijo, string DisplayEnPadre, string ValorEnPadre, string Llaveenhijo, string DisplayEnHijo,
        string ValorEnHijo)
        {
            try
            {
                //CREAMOS UN DATASET PARA GUARDAR 2 DATATABLES QUE NOS PERMITIRAN HACER UNA RELACION DE DEPENDENCIA ENTRE 2 COMBOBOX
                DataSet dtset = new DataSet();
                //LOS DATAADAPTERS QUE NOS PERMITIRAN EL MANEJO DE LA INFO
                MySqlDataAdapter dAdapt_padre = null;
                MySqlDataAdapter dAdapt_hijo = null;
                //COMANDO PARA TRAER LA TABLA PADRE
                MySqlCommand cmdpadre = new MySqlCommand(ProcedPadre, MyConexion);
                cmdpadre.CommandType = CommandType.StoredProcedure;

                //INSTANCIO EL ADAPTER CON EL CMDPADRE COMO PARAMETRO
                dAdapt_padre = new MySqlDataAdapter(cmdpadre);
                //COMANDO PARA TRAER LA TABLA HIJO
                MySqlCommand cmdhijo = new MySqlCommand(ProcedHijo, MyConexion);
                cmdhijo.CommandType = CommandType.StoredProcedure;

                dAdapt_hijo = new MySqlDataAdapter(cmdhijo);
                // llenamos las tablas del dataset
                dAdapt_padre.Fill(dtset, "padre");
                dAdapt_hijo.Fill(dtset, "hijo");
                // creamos la relacion
                dtset.Relations.Add("relacion", dtset.Tables["padre"].Columns[ValorEnPadre], dtset.Tables["hijo"].Columns[Llaveenhijo]);
                //llenamos el padre
                cmboxpadre.DataSource = dtset.Tables["padre"];
                cmboxpadre.DisplayMember = "Nombre";
                cmboxpadre.ValueMember = "ID";

                //llenamos el hijo
                cmboxhijo.DataSource = dtset.Tables["padre"];
                cmboxhijo.DisplayMember = "relacion.Nombre";
                cmboxhijo.ValueMember = "relacion.ID";
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public  void RelacionarDosCombos(string ProcedPadre, string ProcedHijo, ref ComboBox cmboxpadre, ref ComboBox cmboxhijo, string DisplayEnPadre, string ValorEnPadre, string Llaveenhijo, string DisplayEnHijo, string ValorEnHijo)
        {
            try
            {
                //CREAMOS UN DATASET PARA GUARDAR 2 DATATABLES QUE NOS PERMITIRAN HACER UNA RELACION DE DEPENDENCIA ENTRE 2 COMBOBOX
                DataSet dtset = new DataSet();
                //LOS DATAADAPTERS QUE NOS PERMITIRAN EL MANEJO DE LA INFO
                MySqlDataAdapter dAdapt_padre = null;
                MySqlDataAdapter dAdapt_hijo = null;
                //COMANDO PARA TRAER LA TABLA PADRE
                MySqlCommand cmdpadre = new MySqlCommand(ProcedPadre, MyConexion);
                cmdpadre.CommandType = CommandType.StoredProcedure;

                //INSTANCIO EL ADAPTER CON EL CMDPADRE COMO PARAMETRO
                dAdapt_padre = new MySqlDataAdapter(cmdpadre);
                //COMANDO PARA TRAER LA TABLA HIJO
                MySqlCommand cmdhijo = new MySqlCommand(ProcedHijo, MyConexion);
                cmdhijo.CommandType = CommandType.StoredProcedure;

                dAdapt_hijo = new MySqlDataAdapter(cmdhijo);
                // llenamos las tablas del dataset
                dAdapt_padre.Fill(dtset, "padre");
                dAdapt_hijo.Fill(dtset, "hijo");
                // creamos la relacion
                dtset.Relations.Add("relacion", dtset.Tables["padre"].Columns[ValorEnPadre], dtset.Tables["hijo"].Columns[Llaveenhijo]);
                //llenamos el padre
                cmboxpadre.DataSource = dtset.Tables["padre"];
                cmboxpadre.DisplayMember = "Nombre";
                cmboxpadre.ValueMember = "ID";

                //llenamos el hijo
                cmboxhijo.DataSource = dtset.Tables["padre"];
                cmboxhijo.DisplayMember = "relacion.Nombre";
                cmboxhijo.ValueMember = "relacion.ID";
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }


        }
  
        public  void RelacionarDosCombosdirectos(string TablaPadre, string TablaHijo, ref ComboBox cmboxpadre, ref ComboBox cmboxhijo, string DisplayEnPadre, string ValorEnPadre, string Llaveenhijo, string DisplayEnHijo, string ValorEnHijo)
        {
            try
            {
                //CREAMOS UN DATASET PARA GUARDAR 2 DATATABLES QUE NOS PERMITIRAN HACER UNA RELACION DE DEPENDENCIA ENTRE 2 COMBOBOX
                DataSet dtset = new DataSet();
                //LOS DATAADAPTERS QUE NOS PERMITIRAN EL MANEJO DE LA INFO
                MySqlDataAdapter dAdapt_padre = null;
                MySqlDataAdapter dAdapt_hijo = null;
                //COMANDO PARA TRAER LA TABLA PADRE
                MySqlCommand cmdpadre = new MySqlCommand("select * from " + TablaPadre, MyConexion);
                //cmdpadre.CommandType = CommandType.TableDirect

                //INSTANCIO EL ADAPTER CON EL CMDPADRE COMO PARAMETRO
                dAdapt_padre = new MySqlDataAdapter(cmdpadre);
                //COMANDO PARA TRAER LA TABLA HIJO
                MySqlCommand cmdhijo = new MySqlCommand("select * from " + TablaHijo, MyConexion);
                // cmdhijo.CommandType = CommandType.TableDirect

                dAdapt_hijo = new MySqlDataAdapter(cmdhijo);
                // llenamos las tablas del dataset
                dAdapt_padre.Fill(dtset, "padre");
                dAdapt_hijo.Fill(dtset, "hijo");
                // creamos la relacion
                dtset.Relations.Add("relacion", dtset.Tables["padre"].Columns[ValorEnPadre], dtset.Tables["hijo"].Columns[Llaveenhijo]);
                //llenamos el padre
                cmboxpadre.DataSource = dtset.Tables["padre"];
                cmboxpadre.DisplayMember = "Nombre";
                cmboxpadre.ValueMember = "ID";

                //llenamos el hijo
                cmboxhijo.DataSource = dtset.Tables["padre"];
                cmboxhijo.DisplayMember = "relacion.Nombre";
                cmboxhijo.ValueMember = "relacion.ID";
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }


        }
        
        public  void RelacionarDosGrillas(string ProcedPadre, string parametroPadre, object valorparametroPadre, string ProcedHijo, string parametrohijo, object valorparametrohijo, ref DataGridView grillaPadre, ref DataGridView grillaHijo, string LlavePadre, string Llaveenhijo)
        {
            try
            {
                //CREAMOS UN DATASET PARA GUARDAR 2 DATATABLES QUE NOS PERMITIRAN HACER UNA RELACION DE DEPENDENCIA ENTRE 2 COMBOBOX
                DataSet dtset = new DataSet();
                //LOS DATAADAPTERS QUE NOS PERMITIRAN EL MANEJO DE LA INFO
                MySqlDataAdapter dAdapt_padre = null;
                MySqlDataAdapter dAdapt_hijo = null;
                //COMANDO PARA TRAER LA TABLA PADRE
                MySqlCommand cmdpadre = new MySqlCommand(ProcedPadre, MyConexion);
                cmdpadre.Parameters.AddWithValue(parametroPadre, valorparametroPadre);
                cmdpadre.CommandType = CommandType.StoredProcedure;

                //INSTANCIO EL ADAPTER CON EL CMDPADRE COMO PARAMETRO
                dAdapt_padre = new MySqlDataAdapter(cmdpadre);
                //COMANDO PARA TRAER LA TABLA HIJO
                MySqlCommand cmdhijo = new MySqlCommand(ProcedHijo, MyConexion);
                cmdhijo.Parameters.AddWithValue(parametrohijo, valorparametrohijo);
                cmdhijo.CommandType = CommandType.StoredProcedure;

                dAdapt_hijo = new MySqlDataAdapter(cmdhijo);
                // llenamos las tablas del dataset
                dAdapt_padre.Fill(dtset, "padre");
                dAdapt_hijo.Fill(dtset, "hijo");
                // creamos la relacion
                dtset.Relations.Add("relacion", dtset.Tables["padre"].Columns[LlavePadre], dtset.Tables["hijo"].Columns[Llaveenhijo]);
                //llenamos el padre            

                grillaPadre.DataSource = dtset;
                grillaPadre.DataMember = "padre";
                //llenamos el hijo
                grillaHijo.DataSource = dtset;
                grillaHijo.DataMember = "padre.relacion";
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public  void RelacionarDosGrillasBs(string ProcedPadre, string parametroPadre, object valorparametroPadre, string ProcedHijo, string parametrohijo, object valorparametrohijo, ref DataGridView grillaPadre, ref DataGridView grillaHijo, string LlavePadre, string Llaveenhijo,
        ref BindingSource bsource)
        {
            try
            {
                //CREAMOS UN DATASET PARA GUARDAR 2 DATATABLES QUE NOS PERMITIRAN HACER UNA RELACION DE DEPENDENCIA ENTRE 2 COMBOBOX
                DataSet dtset = new DataSet();
                //LOS DATAADAPTERS QUE NOS PERMITIRAN EL MANEJO DE LA INFO
                MySqlDataAdapter dAdapt_padre = null;
                MySqlDataAdapter dAdapt_hijo = null;
                //COMANDO PARA TRAER LA TABLA PADRE
                MySqlCommand cmdpadre = new MySqlCommand(ProcedPadre, MyConexion);
                cmdpadre.Parameters.AddWithValue(parametroPadre, valorparametroPadre);
                cmdpadre.CommandType = CommandType.StoredProcedure;

                //INSTANCIO EL ADAPTER CON EL CMDPADRE COMO PARAMETRO
                dAdapt_padre = new MySqlDataAdapter(cmdpadre);
                //COMANDO PARA TRAER LA TABLA HIJO
                MySqlCommand cmdhijo = new MySqlCommand(ProcedHijo, MyConexion);
                cmdhijo.Parameters.AddWithValue(parametrohijo, valorparametrohijo);
                cmdhijo.CommandType = CommandType.StoredProcedure;

                dAdapt_hijo = new MySqlDataAdapter(cmdhijo);
                // llenamos las tablas del dataset
                dAdapt_padre.Fill(dtset, "padre");
                dAdapt_hijo.Fill(dtset, "hijo");
                // creamos la relacion
                dtset.Relations.Add("relacion", dtset.Tables["padre"].Columns[LlavePadre], dtset.Tables["hijo"].Columns[Llaveenhijo]);
                //llenamos el padre            



                bsource.DataSource = dtset;
                bsource.DataMember = "padre";

                grillaPadre.DataSource = bsource;


                grillaHijo.DataSource = bsource;
                grillaHijo.DataMember = "relacion";


            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public  void RelacionarDosGrillasBS(string ProcedPadre, string ProcedHijo, ref DataGridView grillaPadre, ref DataGridView grillaHijo, string LlavePadre, string Llaveenhijo, ref BindingSource bsourcep, ref BindingSource bsourceh, string[] filtrosp, object[] valoresp,
        string[] filtrosh, object[] valoresh)
        {
            try
            {
                //CREAMOS UN DATASET PARA GUARDAR 2 DATATABLES QUE NOS PERMITIRAN HACER UNA RELACION DE DEPENDENCIA ENTRE 2 COMBOBOX
                DataSet dtset = new DataSet();
                //LOS DATAADAPTERS QUE NOS PERMITIRAN EL MANEJO DE LA INFO
                MySqlDataAdapter dAdapt_padre = null;
                MySqlDataAdapter dAdapt_hijo = null;
                //COMANDO PARA TRAER LA TABLA PADRE
                MySqlCommand cmdpadre = new MySqlCommand(ProcedPadre, MyConexion);
                cmdpadre.CommandType = CommandType.StoredProcedure;

                for (int i = 0; i <= filtrosp.Length - 1; i++)
                {
                    cmdpadre.Parameters.AddWithValue(filtrosp[i], (valoresp[i] == null ? DBNull.Value : valoresp[i]));
                }


                //INSTANCIO EL ADAPTER CON EL CMDPADRE COMO PARAMETRO
                dAdapt_padre = new MySqlDataAdapter(cmdpadre);
                //COMANDO PARA TRAER LA TABLA HIJO
                MySqlCommand cmdhijo = new MySqlCommand(ProcedHijo, MyConexion);
                cmdhijo.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i <= filtrosp.Length - 1; i++)
                {
                    cmdhijo.Parameters.AddWithValue(filtrosh[i], (valoresh[i] == null ? DBNull.Value : valoresh[i]));
                }

                dAdapt_hijo = new MySqlDataAdapter(cmdhijo);
                // llenamos las tablas del dataset
                dAdapt_padre.Fill(dtset, "padre");
                dAdapt_hijo.Fill(dtset, "hijo");
                // creamos la relacion
                dtset.Relations.Add("relacion", dtset.Tables["padre"].Columns[LlavePadre], dtset.Tables["hijo"].Columns[Llaveenhijo]);
                //llenamos el padre            




                bsourcep.DataSource = dtset;
                bsourcep.DataMember = "padre";
                bsourceh.DataSource = bsourcep;
                bsourceh.DataMember = "relacion";



                grillaPadre.DataSource = bsourcep;

                grillaHijo.DataSource = bsourceh;
                // grillaHijo.DataMember = "relacion"


                //grillaPadre.DataSource = dtset
                //grillaPadre.DataMember = "padre"
                //'llenamos el hijo
                //grillaHijo.DataSource = dtset
                //grillaHijo.DataMember = "padre.relacion"
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo realizar el enlace a las grillas.\n" +   ex.Message);
            }


        }

        public  void RelacionarDosGrillas(string ProcedPadre, string ProcedHijo, ref DataGridView grillaPadre, ref DataGridView grillaHijo, string LlavePadre, string Llaveenhijo)
        {
            try
            {
                //CREAMOS UN DATASET PARA GUARDAR 2 DATATABLES QUE NOS PERMITIRAN HACER UNA RELACION DE DEPENDENCIA ENTRE 2 COMBOBOX
                DataSet dtset = new DataSet();
                //LOS DATAADAPTERS QUE NOS PERMITIRAN EL MANEJO DE LA INFO
                MySqlDataAdapter dAdapt_padre = null;
                MySqlDataAdapter dAdapt_hijo = null;
                //COMANDO PARA TRAER LA TABLA PADRE
                MySqlCommand cmdpadre = new MySqlCommand(ProcedPadre, MyConexion);
                cmdpadre.CommandType = CommandType.StoredProcedure;

                //INSTANCIO EL ADAPTER CON EL CMDPADRE COMO PARAMETRO
                dAdapt_padre = new MySqlDataAdapter(cmdpadre);
                //COMANDO PARA TRAER LA TABLA HIJO
                MySqlCommand cmdhijo = new MySqlCommand(ProcedHijo, MyConexion);
                cmdhijo.CommandType = CommandType.StoredProcedure;

                dAdapt_hijo = new MySqlDataAdapter(cmdhijo);
                // llenamos las tablas del dataset
                dAdapt_padre.Fill(dtset, "padre");
                dAdapt_hijo.Fill(dtset, "hijo");
                // creamos la relacion
                dtset.Relations.Add("relacion", dtset.Tables["padre"].Columns[LlavePadre], dtset.Tables["hijo"].Columns[Llaveenhijo]);
                //llenamos el padre            

                grillaPadre.DataSource = dtset;
                grillaPadre.DataMember = "padre";
                //llenamos el hijo
                grillaHijo.DataSource = dtset;
                grillaHijo.DataMember = "padre.relacion";
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }


        }

        public  void RelacionarDosGrillasTablas(string tablaPadre, string tablahija, ref DataGridView grillaPadre, ref DataGridView grillaHijo, string LlavePadre, string Llaveenhijo)
        {
            try
            {
                //CREAMOS UN DATASET PARA GUARDAR 2 DATATABLES QUE NOS PERMITIRAN HACER UNA RELACION DE DEPENDENCIA ENTRE 2 COMBOBOX
                DataSet dtset = new DataSet();
                //LOS DATAADAPTERS QUE NOS PERMITIRAN EL MANEJO DE LA INFO
                MySqlDataAdapter dAdapt_padre = null;
                MySqlDataAdapter dAdapt_hijo = null;
                //COMANDO PARA TRAER LA TABLA PADRE
                MySqlCommand cmdpadre = new MySqlCommand("select * from " + tablaPadre, MyConexion);


                //INSTANCIO EL ADAPTER CON EL CMDPADRE COMO PARAMETRO
                dAdapt_padre = new MySqlDataAdapter(cmdpadre);
                //COMANDO PARA TRAER LA TABLA HIJO
                MySqlCommand cmdhijo = new MySqlCommand("select * from " + tablahija, MyConexion);


                dAdapt_hijo = new MySqlDataAdapter(cmdhijo);
                // llenamos las tablas del dataset
                dAdapt_padre.Fill(dtset, "padre");
                dAdapt_hijo.Fill(dtset, "hijo");
                // creamos la relacion
                dtset.Relations.Add("relacion", dtset.Tables["padre"].Columns[LlavePadre], dtset.Tables["hijo"].Columns[Llaveenhijo]);
                //llenamos el padre            

                grillaPadre.DataSource = dtset;
                grillaPadre.DataMember = "padre";
                //llenamos el hijo
                grillaHijo.DataSource = dtset;
                grillaHijo.DataMember = "padre.relacion";
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }


        }

        public  void Consultar_Y_LlenarDataSet(ref MySqlDataAdapter DA, ref DataSet DTSET, string NOMBRETABLAS, string PROCEDIMIENTO)
        {
            MySqlCommand comando = null;
            comando = new MySqlCommand(PROCEDIMIENTO, MyConexion);
            comando.CommandType = CommandType.StoredProcedure;
            DA = new MySqlDataAdapter(comando);
            try
            {
                DA.Fill(DTSET, NOMBRETABLAS);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }

        }
        
        public  void Consultar_Y_LlenarDataSet(ref MySqlDataAdapter DA, ref DataSet DTSET, string NOMBRETABLAS, string PROCEDIMIENTO, string parametroID, int IDpadre)
        {
            MySqlCommand comando = null;
            comando = new MySqlCommand(PROCEDIMIENTO, MyConexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue(parametroID, IDpadre);
            DA = new MySqlDataAdapter(comando);
            try
            {
                DA.Fill(DTSET, NOMBRETABLAS);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }

        }

        public  void Consultar_Y_LlenarDataSetHijo(ref MySqlDataAdapter DA, ref DataSet DTSET, string NOMBRETABLAS, string PROCEDIMIENTO, string parametroID, int IDpadre)
        {
            MySqlCommand comando = null;
            comando = new MySqlCommand(PROCEDIMIENTO, MyConexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue(parametroID, IDpadre);
            DA = new MySqlDataAdapter(comando);

            try
            {
                DA.Fill(DTSET, NOMBRETABLAS);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public  void Consultar_Y_Llenar(ref MySqlDataAdapter DA, ref DataTable DT, string PROCEDIMIENTO)
        {
            MySqlCommand comando = null;
            comando = new MySqlCommand(PROCEDIMIENTO, MyConexion);
            comando.CommandType = CommandType.StoredProcedure;
            DA = new MySqlDataAdapter(comando);
            try
            {
                DA.Fill(DT);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }

        }

        public  void Consultar_Y_LlenarDataTable(ref MySqlDataAdapter DA, ref DataTable DT, string PROCEDIMIENTO)
        {
            DT.Clear();
            MySqlCommand comando = null;
            comando = new MySqlCommand(PROCEDIMIENTO, MyConexion);
            comando.CommandType = CommandType.StoredProcedure;
            DA = new MySqlDataAdapter(comando);
            try
            {
                DA.Fill(DT);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public  DataTable DevolverDatos(string PROCEDIMIENTO)
        {
            MySqlCommand comando = null;
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();
            Desconectar();
            comando = new MySqlCommand(PROCEDIMIENTO, MyConexion);
            comando.CommandType = CommandType.StoredProcedure;
            da = new MySqlDataAdapter(comando);

            try
            {
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
            return dt;
        }

        public DataTable DevolverDatosTransaccion(string PROCEDIMIENTO)
        {
            MySqlCommand comando = null;
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();
            comando = new MySqlCommand(PROCEDIMIENTO, MyConexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Transaction = trans;
            da = new MySqlDataAdapter(comando);            
                da.Fill(dt);
                return dt;
        }

        public DataTable DevolverDatosTransaccion(string PROCEDIMIENTO,string[] filtros, object[] valores)
        {
            MySqlCommand comando = null;
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();
            comando = new MySqlCommand(PROCEDIMIENTO, MyConexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Transaction = trans;
            for (int i = 0; i <= filtros.Length - 1; i++)
            {
                comando.Parameters.AddWithValue(filtros[i], (valores[i] == null ? DBNull.Value : valores[i]));
            }  
            da = new MySqlDataAdapter(comando);            
                da.Fill(dt);
                return dt;
        }

        public  DataTable Query(string queryString)
        {
            MySqlCommand comando = null;
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();
            Desconectar();
            comando = new MySqlCommand(queryString, MyConexion);
            da = new MySqlDataAdapter(comando);

            try
            {
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
            return dt;
        }

        public  object QueryScalar(string queryString)
        {

            MySqlCommand comando = null;
            Desconectar();
            comando = new MySqlCommand(queryString, MyConexion);
            try
            {
                Conectar();
                return comando.ExecuteScalar();
                // Return DateTime.Now()
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public  DataSet DevolverDatosDataSet(string PROCEDIMIENTO, string filtro, object valor)
        {
            MySqlCommand comando = null;
            MySqlDataAdapter da = null;
            DataSet dt = new DataSet();
            try
            {
                comando = new MySqlCommand(PROCEDIMIENTO, MyConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue(filtro, valor);
                da = new MySqlDataAdapter(comando);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
            return dt;
        }

        public  DataSet DevolverDatosDataSet(string PROCEDIMIENTO)
        {
            MySqlCommand comando = null;
            MySqlDataAdapter da = null;
            DataSet dt = new DataSet();
            try
            {
                comando = new MySqlCommand(PROCEDIMIENTO, MyConexion);
                comando.CommandType = CommandType.StoredProcedure;
                //comando.Parameters.Add(filtro, valor)
                da = new MySqlDataAdapter(comando);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
            return dt;
        }

        public  DataSet DevolverDatosDataSetDirecto(string tabla, string tablads)
        {
            MySqlCommand comando = null;
            MySqlDataAdapter da = null;
            DataSet dt = new DataSet();
            try
            {
                comando = new MySqlCommand("SELECT * FROM " + tabla, MyConexion);
                da = new MySqlDataAdapter(comando);
                da.Fill(dt, tablads);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
            return dt;
        }

        public  DataSet DevolverDatosDataSet(string PROCEDIMIENTO, string filtro, object valor, string nombretabla)
        {
            MySqlCommand comando = null;
            MySqlDataAdapter da = null;
            DataSet dt = new DataSet();
            try
            {
                comando = new MySqlCommand(PROCEDIMIENTO, MyConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue(filtro, valor);
                da = new MySqlDataAdapter(comando);
                da.Fill(dt, nombretabla);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
            return dt;
        }

        public  DataTable DevolverDatosDirecto(string TABLA)
        {
            MySqlCommand comando = null;
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();
            Desconectar();
            try
            {
                comando = new MySqlCommand("SELECT * FROM " + TABLA, MyConexion);
                da = new MySqlDataAdapter(comando);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public  void LlenarDatosDirecto(DataTable dt, string TABLA)
        {
            MySqlCommand comando = null;
            MySqlDataAdapter da = null;
            try
            {
                dt.Clear();
                comando = new MySqlCommand("SELECT * FROM " + TABLA, MyConexion);
                da = new MySqlDataAdapter(comando);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public  void LlenarDatosDirectoDinamicos(DataTable dt, string sql)
        {
            MySqlCommand comando = null;
            MySqlDataAdapter da = null;
            dt.Clear();
            try
            {
                comando = new MySqlCommand(sql, MyConexion);
                da = new MySqlDataAdapter(comando);

                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public  void LlenarDatosDirecto(MySqlDataAdapter da, DataTable dt, string TABLA)
        {
            MySqlCommand comando = null;
            try
            {
                dt.Clear();
                comando = new MySqlCommand("SELECT * FROM " + TABLA, MyConexion);
                da = new MySqlDataAdapter(comando);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public  void LlenarDatos(MySqlDataAdapter da, DataTable dt, string procedimiento)
        {
            MySqlCommand comando = null;
            try
            {
                dt.Clear();
                comando = new MySqlCommand(procedimiento, MyConexion);
                comando.CommandType = CommandType.StoredProcedure;
                da = new MySqlDataAdapter(comando);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public  void LlenarDatos(DataTable dt, string procedimiento)
        {
            MySqlCommand comando = null;
            try
            {
                dt.Clear();
                MySqlDataAdapter da = null;
                comando = new MySqlCommand(procedimiento, MyConexion);
                comando.CommandType = CommandType.StoredProcedure;
                da = new MySqlDataAdapter(comando);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public  void LlenarDatos(string PROCEDIMIENTO, DataTable dt)
        {
            MySqlCommand comando = null;
            MySqlDataAdapter da = null;
            try
            {
                dt.Clear();
                comando = new MySqlCommand(PROCEDIMIENTO, MyConexion);
                comando.CommandType = CommandType.StoredProcedure;
                da = new MySqlDataAdapter(comando);
                Desconectar();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public  void LlenarDatos(string PROCEDIMIENTO, DataTable dt, string filtro, object valor)
        {
            MySqlCommand comando = null;
            MySqlDataAdapter da = null;
            try
            {
                dt.Clear();
                comando = new MySqlCommand(PROCEDIMIENTO, MyConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue(filtro, (valor == null ? DBNull.Value : valor));
                da = new MySqlDataAdapter(comando);
                Desconectar();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public  void LlenarDatos(string PROCEDIMIENTO, DataTable dt, string[] filtros, object[] valores)
        {
            MySqlCommand comando = null;
            MySqlDataAdapter da = null;
            try
            {
                dt.Clear();

                comando = new MySqlCommand(PROCEDIMIENTO, MyConexion);
                comando.CommandTimeout = 10000;
                comando.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i <= filtros.Length - 1; i++)
                {
                    comando.Parameters.AddWithValue(filtros[i], (valores[i] == null ? DBNull.Value : valores[i]));
                }
                da = new MySqlDataAdapter(comando);
                Desconectar();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public  DataTable DevolverDatosPorParametro(string PROCEDIMIENTO, object Parametro1, object Parametro2, string nombreParametro1, string nombreParametro2)
        {
            MySqlCommand comando = null;
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();
            comando = new MySqlCommand(PROCEDIMIENTO, MyConexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue(nombreParametro1, Parametro1);
            comando.Parameters.AddWithValue(nombreParametro2, Parametro2);
            da = new MySqlDataAdapter(comando);
            try
            {
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            return dt;
        }

        public  DataTable DevolverDatos(string PROCEDIMIENTO, string[] filtros, object[] valores)
        {
            MySqlCommand comando = null;
            DataTable dt = new DataTable();
            MySqlDataAdapter da = null;
            try
            {
                comando = new MySqlCommand(PROCEDIMIENTO, MyConexion);
                comando.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i <= filtros.Length - 1; i++)
                {
                    comando.Parameters.AddWithValue(filtros[i], (valores[i] == null ? DBNull.Value : valores[i]));
                }
                da = new MySqlDataAdapter(comando);
                Desconectar();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
            return dt;
        }

        public  DataTable DevolverDatos(string PROCEDIMIENTO, string filtro, object valor)
        {
            MySqlCommand comando = null;
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                comando = new MySqlCommand(PROCEDIMIENTO, MyConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue(filtro, (valor == null ? DBNull.Value : valor));
                da = new MySqlDataAdapter(comando);
                Desconectar();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
            return dt;
        }

        public  DataTable DevolverDatosDinamicos(object sql)
        {
            MySqlCommand comando = null;
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                comando = new MySqlCommand("selectDinamico", MyConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@sql", sql);
                da = new MySqlDataAdapter(comando);
                Desconectar();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
            return dt;
        }

        public  DataRow DevolverPrimerRegistro(string PROCEDIMIENTO, string filtro, object valor)
        {
            MySqlCommand comando = null;
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                comando = new MySqlCommand(PROCEDIMIENTO, MyConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue(filtro, (valor == null ? DBNull.Value : valor));
                da = new MySqlDataAdapter(comando);
                Desconectar();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
            if (dt.Rows.Count > 0)
                return dt.Rows[0];
            return null;
        }

        public  DataRow DevolverPrimerRegistro(string PROCEDIMIENTO, string[] filtros, object[] valores)
        {
            MySqlCommand comando = null;
            DataTable dt = new DataTable();
            MySqlDataAdapter da = null;
            try
            {
                comando = new MySqlCommand(PROCEDIMIENTO, MyConexion);
                comando.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i <= filtros.Length - 1; i++)
                {
                    comando.Parameters.AddWithValue(filtros[i], (valores[i] == null ? DBNull.Value : valores[i]));
                }
                da = new MySqlDataAdapter(comando);
                Desconectar();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }

            if (dt.Rows.Count > 0)
                return dt.Rows[0];
            return null;
        }

        public  object DevolverDato(string PROCEDIMIENTO, string[] filtros, object[] valores)
        {
            MySqlCommand comando = null;
            try
            {
                comando = new MySqlCommand(PROCEDIMIENTO, MyConexion);
                comando.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i <= filtros.Length - 1; i++)
                {
                     comando.Parameters.AddWithValue(filtros[i], (valores[i] == null ? DBNull.Value : valores[i]));
                }
                Desconectar();
                Conectar();
                var X= comando.ExecuteScalar();
                return X;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }
        public object DevolverDatoTransaccion(string PROCEDIMIENTO, string[] filtros, object[] valores)
        {
            MySqlCommand comando = new MySqlCommand(PROCEDIMIENTO, MyConexion);
            comando.Transaction = trans;
            comando.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i <= filtros.Length - 1; i++)
            {
                comando.Parameters.AddWithValue(filtros[i], (valores[i] == null ? DBNull.Value : valores[i]));                
            }
            return comando.ExecuteScalar();
        }
        
        
        public  object DevolverDato(string PROCEDIMIENTO, string parametro, object valor)
        {
            Conectar();
            MySqlCommand comando = null;
            try
            {
                comando = new MySqlCommand(PROCEDIMIENTO, MyConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue(parametro, valor);
                comando.ExecuteNonQuery();
                return comando.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public  object DevolverDato(string PROCEDIMIENTO)
        {
            MySqlCommand comando = null;
            try
            {
                comando = new MySqlCommand(PROCEDIMIENTO, MyConexion);
                comando.CommandType = CommandType.StoredProcedure;
                Desconectar();
                Conectar();
                Object dato = comando.ExecuteScalar();
                return dato;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public  bool EjecutarProcedimiento(string PROCEDIMIENTO)
        {
            MySqlCommand comando = null;
            try
            {
                comando = new MySqlCommand(PROCEDIMIENTO, MyConexion);
                comando.CommandType = CommandType.StoredProcedure;
                Desconectar();
                Conectar();
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public  bool EjecutarProcedimiento(string PROCEDIMIENTO, string parametro, object valor)
        {
            MySqlCommand comando = null;
            comando = new MySqlCommand(PROCEDIMIENTO, MyConexion);
            try
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue(parametro, valor);
                Desconectar();
                Conectar();
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public  bool EjecutarProcedimiento(string PROCEDIMIENTO, string[] filtros, object[] valores)
        {
            MySqlCommand comando = null;
            DataTable dt = new DataTable();
            try
            {
                comando = new MySqlCommand(PROCEDIMIENTO, MyConexion);
                comando.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i <= filtros.Length - 1; i++)
                {
                    comando.Parameters.AddWithValue(filtros[i], (valores[i] == null ? DBNull.Value : valores[i]));
                }
                Desconectar();
                Conectar();
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public bool EjecutarProcedimientoTransaccion(string PROCEDIMIENTO, string[] filtros, object[] valores)
        {
            MySqlCommand comando = null;
            DataTable dt = new DataTable();
            try
            {
                comando = new MySqlCommand(PROCEDIMIENTO, MyConexion);                
                comando.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i <= filtros.Length - 1; i++)
                {
                    comando.Parameters.AddWithValue(filtros[i], (valores[i] == null ? DBNull.Value : valores[i]));
                }                
                comando.Transaction = trans;
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
        }

        public bool EjecutarProcedimientoTransaccion(string PROCEDIMIENTO)
        {
            MySqlCommand comando = null;
            DataTable dt = new DataTable();
            try
            {
                comando = new MySqlCommand(PROCEDIMIENTO, MyConexion);
                comando.CommandType = CommandType.StoredProcedure;               
                comando.Transaction = trans;
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
        }


         public  int EjecutarProcedimientoDevolverId(string PROCEDIMIENTO, string[] filtros, object[] valores)
        {
            try
            {
                MySqlCommand comando = null;
                comando = new MySqlCommand(PROCEDIMIENTO, MyConexion);
                comando.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i <= filtros.Length - 1; i++)
                {
                    comando.Parameters.AddWithValue(filtros[i], valores[i]);
                }
                Conectar();                
                comando.ExecuteNonQuery();
                return UltimoIdInsertado();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
                
            }
            finally
            {
                Desconectar();
            }
        }

         public  int UltimoIdInsertado()
        {
            MySqlCommand COMAND = new MySqlCommand("SELECT DBINFO('sqlca.sqlerrd1')  FROM systables  where tabid = 1;", MyConexion);
            int ID = Convert.ToInt32(  COMAND.ExecuteScalar());
            return ID;
        }

        public  void Consultar_Y_LlenarDataTable_PasandoID(ref MySqlDataAdapter DA, ref DataTable DT, string PROCEDIMIENTO, string pParam, int pID)
        {
            MySqlCommand comando = null;
            try
            {
                DT.Clear();
                comando = new MySqlCommand(PROCEDIMIENTO, MyConexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue(pParam, pID);
                DA = new MySqlDataAdapter(comando);
                DA.Fill(DT);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public  void AutocompletarCombo(DataTable dt, ComboBox cnt)
        {
            AutoCompleteStringCollection stringCol = new AutoCompleteStringCollection();
            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    stringCol.Add(Convert.ToString(row["Nombre"]));
                }
                cnt.AutoCompleteCustomSource = stringCol;
                cnt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                cnt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public  void AutocompletarCombo(DataTable dt, ComboBox cnt, string NombreCampo)
        {
            AutoCompleteStringCollection stringCol = new AutoCompleteStringCollection();
            try
            {
                foreach (DataRow row in dt.Rows)
                {
                    stringCol.Add(Convert.ToString(row[NombreCampo]));
                }
                cnt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                cnt.AutoCompleteCustomSource = stringCol;
                cnt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrio un error inesperado: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public  string devolverfiltrado(string campo, string textoPaFiltrar)
        {
            string[] words = textoPaFiltrar.Split(new char[] { ' ' });
            string filtro = "";
            string word = null;
            foreach (string word_loopVariable in words)
            {
                word = word_loopVariable;
                if (string.IsNullOrEmpty(filtro))
                {
                    filtro += "CONVERT(" + campo + ", 'System.String')  like '%" + word.Trim() + "%'";
                }
                else
                {
                    filtro += " and CONVERT(" + campo + ", 'System.String')  like '%" + word.Trim() + "%'";
                }
            }
            return filtro;
        }

        public  string devolverfiltradoSQL(string campo, string textoPaFiltrar)
        {
            string[] words = textoPaFiltrar.Split(new char[] { ' ' });
            string filtro = "";
            string word = null;
            foreach (string word_loopVariable in words)
            {
                word = word_loopVariable;
                if (string.IsNullOrEmpty(filtro))
                {
                    filtro += campo + " like '%" + word.Trim() + "%'";
                }
                else
                {
                    filtro += " and " + campo + "   like '%" + word.Trim() + "%'";
                }
            }
            return filtro;
        }

        #endregion

    }
}
