using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Services;
using System.Web.Script.Serialization;
using System.Data;
using System.Data.SqlClient;


/// <summary>
/// Summary description for WebService
/// </summary>
/// [WebService]  
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{
    private const string DBNAME = "DB_9C4DA8_PhoneCards"/*"PhoneCards""globalte_PhoneCards"*/;
    public WebService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
        int a = 0;
        int b = a + 10;
    }

    [WebMethod]
    public string HelloWorld(String temp)
    {
        return temp;
    }


    [WebMethod]
    public Employee[] GetEmployessXML()
    {
        Employee[] emps = new Employee[] {  
            new Employee()  
            {  
                Id=101,  
                Name="Nitin",  
                Salary=10000  
            },  
            new Employee()  
            {  
                Id=102,  
                Name="Dinesh",  
                Salary=100000  
            }  
        };
        return emps;
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]
    public string GetEmployessJSON()
    {
        Employee[] emps = new Employee[] {  
            new Employee()  
            {  
                Id=101,  
                Name="Nitin",  
                Salary=10000  
            },  
            new Employee()  
            {  
                Id=102,  
                Name="Dinesh",  
                Salary=100000  
            }  
        };
        return new JavaScriptSerializer().Serialize(emps);
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]
    public string getAllProvincias()
    {
        SqlConnection con = ManageConnect.OpenConnection();
        List<Provincias> province = new List<Provincias>();
        try
        {
            SqlCommand myCommand = new SqlCommand("Select * from " + DBNAME + ".dbo.Provincias", con);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    Provincias proVin = new Provincias();
                    //proVin.PdID = Convert.ToInt32(row[ProvinciasColumn.pkID].ToString());
                    int pkID; ;
                    proVin.PkID = Int32.TryParse(row[ProvinciasColumn.pkID].ToString(), out pkID) ? pkID.ToString() : "0";
                    proVin.Nombre = row[ProvinciasColumn.Nombre].ToString();
                    province.Add(proVin);
                }
            }
        }
        catch { }
        finally
        {
            ManageConnect.CloseConnection(con);
        }
        return new JavaScriptSerializer().Serialize(province);
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]
    public string getAllDistritos()
    {
        SqlConnection con = ManageConnect.OpenConnection();
        List<Distritos> disList = new List<Distritos>();
        try
        {
            SqlCommand myCommand = new SqlCommand("Select * from " + DBNAME + ".dbo.Distritos", con);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    Distritos dis = new Distritos();
                    int pkID; ;
                    dis.PkID = Int32.TryParse(row[DistritosColumn.pkID].ToString(), out pkID) ? pkID.ToString() : "0";
                    dis.ProvinciaID = row[DistritosColumn.ProvinciaID].ToString();
                    dis.Nombre = row[DistritosColumn.Nombre].ToString();
                    disList.Add(dis);
                }
            }
        }
        catch { }
        finally
        {
            ManageConnect.CloseConnection(con);
        }
        return new JavaScriptSerializer().Serialize(disList);
    }
    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]
    public string getAllCorregimientos()
    {
        SqlConnection con = ManageConnect.OpenConnection();
        List<Corregimientos> disList = new List<Corregimientos>();
        try
        {
            SqlCommand myCommand = new SqlCommand("Select * from " + DBNAME + ".dbo.Corregimientos", con);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    Corregimientos dis = new Corregimientos();
                    int pkID; ;
                    dis.PkID = Int32.TryParse(row[CorregimientosColumn.pkID].ToString(), out pkID) ? pkID.ToString() : "0";
                    dis.DistritoID = row[CorregimientosColumn.DistritoID].ToString();
                    dis.Nombre = row[CorregimientosColumn.Nombre].ToString();
                    disList.Add(dis);
                }
            }
        }
        catch { }
        finally
        {
            ManageConnect.CloseConnection(con);
        }
        return new JavaScriptSerializer().Serialize(disList);
    }



    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]
    public string getAllZonas()
    {
        SqlConnection con = ManageConnect.OpenConnection();
        List<Zonas> disList = new List<Zonas>();
        try
        {
            SqlCommand myCommand = new SqlCommand("Select * from " + DBNAME + ".dbo.Zonas", con);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    Zonas dis = new Zonas();
                    //dis.PkID = Convert.ToInt32(row[ZonasColumn.pkID].ToString());
                    int pkID; ;
                    dis.PkID = Int32.TryParse(row[ZonasColumn.pkID].ToString(), out pkID) ? pkID.ToString() : "0";

                    dis.Nombre = row[ZonasColumn.Nombre].ToString();
                    disList.Add(dis);
                }
            }
        }
        catch { }
        finally
        {
            ManageConnect.CloseConnection(con);
        }
        return new JavaScriptSerializer().Serialize(disList);
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]
    public string getFrecuenciaVisita()
    {
        SqlConnection con = ManageConnect.OpenConnection();
        List<FrecuenciaVisita> disList = new List<FrecuenciaVisita>();
        try
        {
            SqlCommand myCommand = new SqlCommand("Select * from " + DBNAME + ".dbo.FrecuenciaVisitas", con);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    FrecuenciaVisita dis = new FrecuenciaVisita();
                    int pkID;
                    dis.PkID = Int32.TryParse(row[FrecuenciaVisitaColumn.pkID].ToString(), out pkID) ? pkID.ToString() : "0";

                    dis.Codigo = row[FrecuenciaVisitaColumn.Codigo].ToString();
                    dis.Description = row[FrecuenciaVisitaColumn.Descripcion].ToString();
                    disList.Add(dis);
                }
            }
        }
        catch { }
        finally
        {
            ManageConnect.CloseConnection(con);
        }
        return new JavaScriptSerializer().Serialize(disList);
    }


    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]
    public string getAllVendedoresPorPuntosDeVenta()
    {
        SqlConnection con = ManageConnect.OpenConnection();
        List<VendedoresPorPuntosDeVenta> disList = new List<VendedoresPorPuntosDeVenta>();
        try
        {
            SqlCommand myCommand = new SqlCommand("Select * from " + DBNAME + ".dbo.VendedoresPorPuntosDeVenta", con);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    VendedoresPorPuntosDeVenta dis = new VendedoresPorPuntosDeVenta();
                    //dis.PkID = Convert.ToInt32(row[ZonasColumn.pkID].ToString());
                    int pkID;
                    dis.PkID = Int32.TryParse(row[VendedoresPorPuntosDeVentaColumn.pkID].ToString(), out pkID) ? pkID.ToString() : "0";

                    int vendedorid;
                    dis.VendedorID = Int32.TryParse(row[VendedoresPorPuntosDeVentaColumn.VendedorID].ToString(), out vendedorid) ? vendedorid.ToString() : "0";

                    int pdvid;
                    dis.PDVID = Int32.TryParse(row[VendedoresPorPuntosDeVentaColumn.PDVID].ToString(), out pdvid) ? pdvid.ToString() : "0";


                    dis.FrecuenciaVisitaID = row[VendedoresPorPuntosDeVentaColumn.FrecuenciaVisitaID].ToString();
                    disList.Add(dis);
                }
            }
        }
        catch { }
        finally
        {
            ManageConnect.CloseConnection(con);
        }
        return new JavaScriptSerializer().Serialize(disList);
    }







    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]
    public string getAllPuntos()
    {
        SqlConnection con = ManageConnect.OpenConnection();
        List<PuntosDeVenta> puntosList = new List<PuntosDeVenta>();
        try
        {
            SqlCommand myCommand = new SqlCommand("Select * from " + DBNAME + ".dbo.PuntosDeVenta", con);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    PuntosDeVenta pun = new PuntosDeVenta();
                    int pkID; ;
                    pun.PkID = Int32.TryParse(row[PuntosDeVentaColumn.pkID].ToString(), out pkID) ? pkID.ToString() : "0";

                    int factDeptID1;
                    pun.FactDeptID = Int32.TryParse(row[PuntosDeVentaColumn.FactDeptID].ToString(), out factDeptID1) ? factDeptID1.ToString() : "0";

                    pun.Nombre = row[PuntosDeVentaColumn.Nombre].ToString();
                    pun.Direccion = row[PuntosDeVentaColumn.Direccion].ToString();

                    int provinciaID;
                    pun.ProvinciaID = Int32.TryParse(row[PuntosDeVentaColumn.ProvinciaID].ToString(), out provinciaID) ? provinciaID.ToString() : "0";
                    int distritoID;
                    pun.DistritoID = Int32.TryParse(row[PuntosDeVentaColumn.DistritoID].ToString(), out distritoID) ? distritoID.ToString() : "0";
                    int zonaID;
                    pun.ZonaID = Int32.TryParse(row[PuntosDeVentaColumn.ZonaID].ToString(), out zonaID) ? zonaID.ToString() : "0";
                    pun.DireccionesAdicionales = row[PuntosDeVentaColumn.DireccionesAdicionales].ToString();
                    pun.Telefonos = row[PuntosDeVentaColumn.Telefonos].ToString();
                    Boolean active;
                    pun.Activo = Boolean.TryParse(row[PuntosDeVentaColumn.Telefonos].ToString(), out active) ? active.ToString() : "False";

                    double lat;
                    pun.PosicionLat = double.TryParse(row[PuntosDeVentaColumn.PosicionLat].ToString(), out lat) ? lat.ToString() : "0";
                    double lon;
                    pun.PosicionLon = double.TryParse(row[PuntosDeVentaColumn.PosicionLon].ToString(), out lon) ? lon.ToString() : "0";
                    pun.Email1 = row[PuntosDeVentaColumn.Email1].ToString();
                    pun.Email2 = row[PuntosDeVentaColumn.Email2].ToString();
                    puntosList.Add(pun);
                }
            }
        }
        catch { }
        finally
        {
            ManageConnect.CloseConnection(con);
        }
        return new JavaScriptSerializer().Serialize(puntosList);
    }


    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]
    public string getAllVendedores()
    {
        SqlConnection con = ManageConnect.OpenConnection();
        List<Vendedores> vendeList = new List<Vendedores>();
        try
        {
            SqlCommand myCommand = new SqlCommand("Select * from " + DBNAME + ".dbo.Vendedores", con);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    Vendedores pun = new Vendedores();
                    int pkID; ;
                    pun.PkID = Int32.TryParse(row[VendedoresColumn.pkID].ToString(), out pkID) ? pkID.ToString() : "0";

                    pun.NombreCompleto = row[VendedoresColumn.NombreCompleto].ToString();
                    pun.NombreUsuario = row[VendedoresColumn.NombreUsuario].ToString();
                    pun.Clave = row[VendedoresColumn.Clave].ToString();
                    pun.Direccion = row[VendedoresColumn.Direccion].ToString();
                    pun.DocIdent = row[VendedoresColumn.DocIdent].ToString();
                    pun.Telefonos = row[VendedoresColumn.Telefonos].ToString();
                    Boolean active;
                    pun.Activo = Boolean.TryParse(row[VendedoresColumn.Activo].ToString(), out active) ? active.ToString() : "False";
                    pun.Email1 = row[VendedoresColumn.Email1].ToString();
                    pun.Email2 = row[VendedoresColumn.Email2].ToString();
                    vendeList.Add(pun);
                }
            }
        }
        catch { }
        finally
        {
            ManageConnect.CloseConnection(con);
        }
        return new JavaScriptSerializer().Serialize(vendeList);
    }


    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]
    public string getAllEncuestaDisenos()
    {
        SqlConnection con = ManageConnect.OpenConnection();
        List<EncuestaDisenos> encuestaDisenosList = new List<EncuestaDisenos>();
        try
        {
            SqlCommand myCommand = new SqlCommand("Select * from " + DBNAME + ".dbo.EncuestaDisenos", con);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    EncuestaDisenos pun = new EncuestaDisenos();
                    int pkID; ;
                    pun.PkID = Int32.TryParse(row[EncuestaDisenosColumn.pkID].ToString(), out pkID) ? pkID.ToString() : "0";
                    pun.Nombre = row[EncuestaDisenosColumn.Nombre].ToString();
                    pun.Descripcion = row[EncuestaDisenosColumn.Descripcion].ToString();
                    //pun.GrupoRespuestasID = row[EncuestaDisenosColumn.GrupoRespuestasID].ToString();
                    Boolean active;
                    pun.Activo = Boolean.TryParse(row[VendedoresColumn.Activo].ToString(), out active) ? active.ToString() : "False";
                    encuestaDisenosList.Add(pun);
                }
            }
        }
        catch { }
        finally
        {
            ManageConnect.CloseConnection(con);
        }
        return new JavaScriptSerializer().Serialize(encuestaDisenosList);
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]
    public string getAllEncuestasPreguntas()
    {
        SqlConnection con = ManageConnect.OpenConnection();
        List<EncuestasPreguntas> encuestaDisenosList = new List<EncuestasPreguntas>();
        try
        {
            SqlCommand myCommand = new SqlCommand("Select * from " + DBNAME + ".dbo.EncuestaPreguntas", con);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    EncuestasPreguntas pun = new EncuestasPreguntas();
                    int pkID; ;
                    pun.PkID = Int32.TryParse(row[EncuestasPreguntasColumn.pkID].ToString(), out pkID) ? pkID.ToString() : "0";
                    pun.DisenoID = row[EncuestasPreguntasColumn.DisenoID].ToString();
                    pun.PosicionColumna = row[EncuestasPreguntasColumn.PosicionColumna].ToString();
                    pun.NombreColumna = row[EncuestasPreguntasColumn.NombreColumna].ToString();
                    pun.TextoPregunta = row[EncuestasPreguntasColumn.TextoPregunta].ToString();
                    pun.QType = row[EncuestasPreguntasColumn.QType].ToString();
                    pun.GrupoRespuestasID = row[EncuestasPreguntasColumn.GrupoRespuestasID].ToString();
                    encuestaDisenosList.Add(pun);
                }
            }
        }
        catch { }
        finally
        {
            ManageConnect.CloseConnection(con);
        }
        return new JavaScriptSerializer().Serialize(encuestaDisenosList);
    }


    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]
    public string getAllEncuetadatos()
    {
        SqlConnection con = ManageConnect.OpenConnection();
        List<EncuestaDatos> encuestaDisenosList = new List<EncuestaDatos>();
        try
        {
            SqlCommand myCommand = new SqlCommand("Select * from " + DBNAME + ".dbo.EncuestaDatos", con);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    EncuestaDatos pun = new EncuestaDatos();
                    int pkID; ;
                    pun.PkID = Int32.TryParse(row[EncuestaDatosColumn.pkID].ToString(), out pkID) ? pkID.ToString() : "0";
                    pun.DisenoID = row[EncuestaDatosColumn.DisenoID].ToString();
                    pun.VendedorID = row[EncuestaDatosColumn.VendedorID].ToString();
                    pun.PDVID = row[EncuestaDatosColumn.PDVID].ToString();
                    pun.FechaHoraEncuesta = row[EncuestaDatosColumn.FechaHoraEncuesta].ToString();
                    pun.PosicionEncuestaLat = row[EncuestaDatosColumn.PosicionEncuestaLat].ToString();
                    pun.PosicionEncuestaLon = row[EncuestaDatosColumn.PosicionEncuestaLon].ToString();
                    pun.FechaHoraRegistro = row[EncuestaDatosColumn.FechaHoraRegistro].ToString();
                    pun.PosicionRegistroLat = row[EncuestaDatosColumn.PosicionRegistroLat].ToString();
                    pun.PosicionRegistroLon = row[EncuestaDatosColumn.PosicionRegistroLon].ToString();
                    pun.Pregunta01 = row[EncuestaDatosColumn.Pregunta01].ToString();
                    pun.Pregunta02 = row[EncuestaDatosColumn.Pregunta02].ToString();
                    pun.Pregunta03 = row[EncuestaDatosColumn.Pregunta03].ToString();
                    pun.Pregunta04 = row[EncuestaDatosColumn.Pregunta04].ToString();
                    pun.Pregunta05 = row[EncuestaDatosColumn.Pregunta05].ToString();
                    pun.Pregunta06 = row[EncuestaDatosColumn.Pregunta06].ToString();
                    pun.Pregunta07 = row[EncuestaDatosColumn.Pregunta07].ToString();
                    pun.Pregunta08 = row[EncuestaDatosColumn.Pregunta08].ToString();
                    pun.Pregunta09 = row[EncuestaDatosColumn.Pregunta09].ToString();
                    pun.Pregunta10 = row[EncuestaDatosColumn.Pregunta10].ToString();
                    encuestaDisenosList.Add(pun);
                }
            }
        }
        catch { }
        finally
        {
            ManageConnect.CloseConnection(con);
        }
        return new JavaScriptSerializer().Serialize(encuestaDisenosList);
    }





    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]
    public string getAllEncuestaRespuestaGrupos()
    {
        SqlConnection con = ManageConnect.OpenConnection();
        List<EncuestaRespuestaGrupos> encuestaDisenosList = new List<EncuestaRespuestaGrupos>();
        try
        {
            SqlCommand myCommand = new SqlCommand("Select * from " + DBNAME + ".dbo.EncuestaRespuestaGrupos", con);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    EncuestaRespuestaGrupos pun = new EncuestaRespuestaGrupos();
                    int pkID; ;
                    pun.PkID = Int32.TryParse(row[EncuestaRespuestaGruposColumn.pkID].ToString(), out pkID) ? pkID.ToString() : "0";
                    pun.Nombre = row[EncuestaRespuestaGruposColumn.Nombre].ToString();
                    pun.Descripcion = row[EncuestaRespuestaGruposColumn.Descripcion].ToString();
                    encuestaDisenosList.Add(pun);
                }
            }
        }
        catch { }
        finally
        {
            ManageConnect.CloseConnection(con);
        }
        return new JavaScriptSerializer().Serialize(encuestaDisenosList);
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json, UseHttpGet = true)]
    public string getAllEncuestaRespuestas()
    {
        SqlConnection con = ManageConnect.OpenConnection();
        List<EncuestaRespuestas> encuestaDisenosList = new List<EncuestaRespuestas>();
        try
        {
            SqlCommand myCommand = new SqlCommand("Select * from " + DBNAME + ".dbo.EncuestaRespuestas", con);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    EncuestaRespuestas pun = new EncuestaRespuestas();
                    int pkID; ;
                    pun.PkID = Int32.TryParse(row[EncuestaRespuestasColumn.pkID].ToString(), out pkID) ? pkID.ToString() : "0";
                    pun.Codigo = row[EncuestaRespuestasColumn.Codigo].ToString();
                    pun.Descripcion = row[EncuestaRespuestasColumn.Descripcion].ToString();
                    pun.GrupoRespuestasID = row[EncuestaRespuestasColumn.GrupoRespuestasID].ToString();
                    encuestaDisenosList.Add(pun);
                }
            }
        }
        catch { }
        finally
        {
            ManageConnect.CloseConnection(con);
        }
        return new JavaScriptSerializer().Serialize(encuestaDisenosList);
    }

    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string addNewEncuestaDatos(String disenoID, String vendedorID, String pDVID, String fechaHoraEncuesta,
        String posicionEncuestaLat, String posicionEncuestaLon, String fechaHoraRegistro, String posicionRegistroLat,
        String posicionRegistroLon, String pregunta01, String pregunta02, String pregunta03, String pregunta04, String pregunta05,
        String pregunta06, String pregunta07, String pregunta08, String pregunta09, String pregunta10)
    {
        string cmdString = "INSERT INTO " + DBNAME + ".dbo.EncuestaDatos" +
            " (DisenoID,VendedorID,PDVID,FechaHoraEncuesta,PosicionEncuestaLat,PosicionEncuestaLon,FechaHoraRegistro," +
        "PosicionRegistroLat,PosicionRegistroLon,Pregunta01,Pregunta02,Pregunta03,Pregunta04,Pregunta05,Pregunta06,Pregunta07," +
        "Pregunta08,Pregunta09,Pregunta10) VALUES (@disenoID, @vendedorID, @pDVID,  @fechaHoraEncuesta," +
        "@posicionEncuestaLat, @posicionEncuestaLon, @fechaHoraRegistro,  @posicionRegistroLat," +
        "@posicionRegistroLon, @pregunta01, @pregunta02, @pregunta03,@pregunta04, @pregunta05," +
        "@pregunta06, @pregunta07, @pregunta08, @pregunta09, @pregunta10)";
        SqlConnection con = ManageConnect.OpenConnection();
        Result result = new Result();
        try
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = con;
                comm.CommandType = CommandType.Text;
                comm.CommandText = cmdString;
                comm.Parameters.AddWithValue("@disenoID", disenoID);
                comm.Parameters.AddWithValue("@vendedorID", vendedorID);
                comm.Parameters.AddWithValue("@pDVID", pDVID);
                comm.Parameters.AddWithValue("@fechaHoraEncuesta", fechaHoraEncuesta);
                comm.Parameters.AddWithValue("@posicionEncuestaLat", posicionEncuestaLat);
                comm.Parameters.AddWithValue("@posicionEncuestaLon", posicionEncuestaLon);
                comm.Parameters.AddWithValue("@fechaHoraRegistro", fechaHoraRegistro);
                comm.Parameters.AddWithValue("@posicionRegistroLat", posicionRegistroLat);
                comm.Parameters.AddWithValue("@posicionRegistroLon", posicionRegistroLon);
                comm.Parameters.AddWithValue("@pregunta01", pregunta01);
                comm.Parameters.AddWithValue("@pregunta02", pregunta02);
                comm.Parameters.AddWithValue("@pregunta03", pregunta03);
                comm.Parameters.AddWithValue("@pregunta04", pregunta04);
                comm.Parameters.AddWithValue("@pregunta05", pregunta05);
                comm.Parameters.AddWithValue("@pregunta06", pregunta06);
                comm.Parameters.AddWithValue("@pregunta07", pregunta07);
                comm.Parameters.AddWithValue("@pregunta08", pregunta08);
                comm.Parameters.AddWithValue("@pregunta09", pregunta09);
                comm.Parameters.AddWithValue("@pregunta10", pregunta10);
                try
                {
                    comm.ExecuteNonQuery();
                    comm.Parameters.Clear();
                    comm.CommandText = "SELECT @@IDENTITY";

                    int identity = Convert.ToInt32(comm.ExecuteScalar());
                    if (identity > 0)
                    {
                        result.Succes = true;
                        result.Message = identity.ToString();
                    }
                }
                catch (SqlException e)
                {
                    // do something with the exception
                    // don't hide it
                    result.Succes = false;
                    result.Message = e.ToString();
                }
            }
        }
        catch (Exception e) {
            result.Succes = false;
            result.Message = e.ToString();
        }
        finally
        {
            ManageConnect.CloseConnection(con);
        }
        return new JavaScriptSerializer().Serialize(result) ;
    }

   
    [WebMethod]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public string addNewPuntosDeVenta(String factDeptID, String nombre, String direccion, String provinciaID, String distritoID, String corregimientoID, String zonaID,
        String direccionesAdicionales, String telefonos, String activo, String posicionLat, String posicionLon, String email1, String email2)
    {
        string cmdString = "INSERT INTO " + DBNAME + ".dbo.PuntosDeVenta" +
            " (FactDeptID,Nombre,Direccion,ProvinciaID,DistritoID,CorregimientoID,ZonaID,DireccionesAdicionales,Telefonos,Activo,PosicionLat,PosicionLon,Email1,Email2)"
        + " VALUES (@factDeptID,@nombre,@direccion,@provinciaID,@distritoID,@corregimientoID,@zonaID,@direccionesAdicionales,@telefonos,@activo,@posicionLat,@posicionLon,@email1,@email2)";
        SqlConnection con = ManageConnect.OpenConnection();
        Result result = new Result();
        try
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = con;
                comm.CommandType = CommandType.Text;
                comm.CommandText = cmdString;
                comm.Parameters.AddWithValue("@factDeptID", factDeptID);
                comm.Parameters.AddWithValue("@nombre", nombre);
                comm.Parameters.AddWithValue("@direccion", direccion);
                comm.Parameters.AddWithValue("@provinciaID", provinciaID);
                comm.Parameters.AddWithValue("@distritoID", distritoID);
                comm.Parameters.AddWithValue("@corregimientoID",corregimientoID);
                comm.Parameters.AddWithValue("@zonaID", zonaID);
                comm.Parameters.AddWithValue("@direccionesAdicionales", direccionesAdicionales);
                comm.Parameters.AddWithValue("@telefonos", telefonos);
                comm.Parameters.AddWithValue("@activo", activo);
                comm.Parameters.AddWithValue("@posicionLat", posicionLat);
                comm.Parameters.AddWithValue("@posicionLon", posicionLon);
                comm.Parameters.AddWithValue(@"email1", email1);
                comm.Parameters.AddWithValue(@"email2", email2);
                try
                {
                    comm.ExecuteNonQuery();
                    comm.Parameters.Clear();
                    comm.CommandText = "SELECT @@IDENTITY";

                    int identity = Convert.ToInt32(comm.ExecuteScalar());
                    if (identity > 0)
                    {
                        result.Succes = true;
                        result.Message = identity.ToString();
                    }
                }
                catch (SqlException e)
                {
                    // do something with the exception
                    // don't hide it
                    result.Succes = false;
                    result.Message = e.ToString();
                }
            }
        }
        catch (Exception e)
        {
            result.Succes = false;
            result.Message = e.ToString();
        }
        finally
        {
            ManageConnect.CloseConnection(con);
        }
        return new JavaScriptSerializer().Serialize(result);
    }
}
