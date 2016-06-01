using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for EncuestaDisenos
/// </summary>
public class EncuestaDisenos
{
	public EncuestaDisenos()
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
    private String descripcion;

    public String Descripcion
    {
        get { return descripcion; }
        set { descripcion = value; }
    }
    private String activo;

    public String Activo
    {
        get { return activo; }
        set { activo = value; }
    }
}