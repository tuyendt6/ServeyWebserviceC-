using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for EncuestasPreguntas
/// </summary>
public class EncuestasPreguntas
{
	public EncuestasPreguntas()
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

    private String disenoID;

    public String DisenoID
    {
        get { return disenoID; }
        set { disenoID = value; }
    }

    private String posicionColumna;

    public String PosicionColumna
    {
        get { return posicionColumna; }
        set { posicionColumna = value; }
    }

    private String nombreColumna;

    public String NombreColumna
    {
        get { return nombreColumna; }
        set { nombreColumna = value; }
    }

    private String textoPregunta;

    public String TextoPregunta
    {
        get { return textoPregunta; }
        set { textoPregunta = value; }
    }

    private String qType;

    public String QType
    {
        get { return qType; }
        set { qType = value; }
    }

    private String grupoRespuestasID;

    public String GrupoRespuestasID
    {
        get { return grupoRespuestasID; }
        set { grupoRespuestasID = value; }
    }
}