using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Distritos
/// </summary>
public class Distritos
{
	public Distritos()
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
    private String provinciaID;

    public String ProvinciaID
    {
        get { return provinciaID; }
        set { provinciaID = value; }
    }
    private String nombre;

    public String Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

}