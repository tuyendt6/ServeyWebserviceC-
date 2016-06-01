using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Zonas
/// </summary>
public class VendedoresPorPuntosDeVenta
{
    public VendedoresPorPuntosDeVenta()
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
    private String vendedorid;

    public String VendedorID
    {
        get { return vendedorid; }
        set { vendedorid = value; }
    }

    private String pdvid;

    public String PDVID
    {
        get { return pdvid; }
        set { pdvid = value; }
    }

    private String frecuenciavisitaid;

    public String FrecuenciaVisitaID
    {
        get { return frecuenciavisitaid; }
        set { frecuenciavisitaid = value; }
    }
}