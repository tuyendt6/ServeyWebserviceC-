using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PuntosDeVenta
/// </summary>
public class PuntosDeVenta
{
	public PuntosDeVenta()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    private String pkID;

    public String PkID
    {
        get { return pkID; }
        set { pkID = value; }
    }

    private String factDeptID;

    public String FactDeptID
    {
        get { return factDeptID; }
        set { factDeptID = value; }
    }


    private String nombre;

    public String Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    private String direccion;

    public String Direccion
    {
        get { return direccion; }
        set { direccion = value; }
    }


    private String provinciaID;

    public String ProvinciaID
    {
        get { return provinciaID; }
        set { provinciaID = value; }
    }


    private String distritoID;

    public String DistritoID
    {
        get { return distritoID; }
        set { distritoID = value; }
    }


    private String zonaID;

    public String ZonaID
    {
        get { return zonaID; }
        set { zonaID = value; }
    }


    private String direccionesAdicionales;

    public String DireccionesAdicionales
    {
        get { return direccionesAdicionales; }
        set { direccionesAdicionales = value; }
    }


    private String telefonos;

    public String Telefonos
    {
        get { return telefonos; }
        set { telefonos = value; }
    }


    private String activo;

    public String Activo
    {
        get { return activo; }
        set { activo = value; }
    }


    private String posicionLat;

    public String PosicionLat
    {
        get { return posicionLat; }
        set { posicionLat = value; }
    }


    private String posicionLon;

    public String PosicionLon
    {
        get { return posicionLon; }
        set { posicionLon = value; }
    }

    private String email1;

    public String Email1
    {
        get { return email1; }
        set { email1 = value; }
    }

    private String email2;

    public String Email2
    {
        get { return email2; }
        set { email2 = value; }
    }

}