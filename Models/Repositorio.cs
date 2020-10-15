using System.Collections.Generic;

namespace FiestaInvitados.Models 
{
    public static class Repositorio
    {
        private static List<InvitadosRespuesta> respuestas = new List<InvitadosRespuesta>();

        public static IEnumerable<InvitadosRespuesta> Respuestas => respuestas;

        public static void AddRespuesta(InvitadosRespuesta respuesta) {
            respuestas.Add(respuesta);
        }
    }    
}