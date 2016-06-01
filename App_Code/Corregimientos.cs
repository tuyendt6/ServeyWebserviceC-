using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Distritos
/// </summary>
public class Corregimientos
{
    public Corregimientos()
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
    private String distritoID;

    public String DistritoID
    {
        get { return distritoID; }
        set { distritoID = value; }
    }
    private String nombre;

    public String Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
}