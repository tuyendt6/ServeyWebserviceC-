using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for EncuestaRespuestas
/// </summary>
public class EncuestaRespuestas
{
	public EncuestaRespuestas()
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
    private String codigo;

    public String Codigo
    {
        get { return codigo; }
        set { codigo = value; }
    }
    private String descripcion;

    public String Descripcion
    {
        get { return descripcion; }
        set { descripcion = value; }
    }
    private String grupoRespuestasID;

    public String GrupoRespuestasID
    {
        get { return grupoRespuestasID; }
        set { grupoRespuestasID = value; }
    }
}