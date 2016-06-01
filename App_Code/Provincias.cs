using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Provincias
/// </summary>
public class Provincias
{
    public Provincias()
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

    private String nombre;

    public String Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
}