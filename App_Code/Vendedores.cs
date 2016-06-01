using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Vendedores
/// </summary>
public class Vendedores
{
    public Vendedores()
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
    private String nombreCompleto;

    public String NombreCompleto
    {
        get { return nombreCompleto; }
        set { nombreCompleto = value; }
    }
    private String nombreUsuario;

    public String NombreUsuario
    {
        get { return nombreUsuario; }
        set { nombreUsuario = value; }
    }
    private String clave;

    public String Clave
    {
        get { return clave; }
        set { clave = value; }
    }
    private String direccion;

    public String Direccion
    {
        get { return direccion; }
        set { direccion = value; }
    }
    private String docIdent;

    public String DocIdent
    {
        get { return docIdent; }
        set { docIdent = value; }
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