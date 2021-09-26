using System;

namespace WebSiberian.Token.Seguridad
{
    public interface ISecurityToken
    {
        string CrearToken(string nombreUsuario);
    }
}
