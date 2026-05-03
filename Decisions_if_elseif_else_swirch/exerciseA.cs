using System;
using System.Collections.Generic;
using System.Linq;

public class MotorReglasComplejo
{
    public static void Main()
    {
        var contexto = new Dictionary<string, object>
        {
            { "Usuario", "Admin" },
            { "NivelAcceso", 10 },
            { "Bloqueado", false },
            { "Permisos", new List<string> { "read", "write", "delete" } }
        };

        string resultado = ProcesarSolicitud(contexto);
        Console.WriteLine(resultado);
    }

    public static string ProcesarSolicitud(Dictionary<string, object> ctx)
    {
        // 1. If anidado complejo con operadores lógicos
        if (ctx.ContainsKey("Usuario") && ctx["Usuario"] is string usuario && !string.IsNullOrEmpty(usuario))
        {
            // 2. Else If con evaluación de tipo y conversión
            if (ctx.TryGetValue("Bloqueado", out object esBloqueado) && (bool)esBloqueado)
            {
                return "Acceso denegado: Usuario bloqueado.";
            }
            else if (ctx.TryGetValue("NivelAcceso", out object nivel) && nivel is int n && n > 5)
            {
                // 3. IF-ELSEIF-ELSE interno muy anidado
                if (ctx.ContainsKey("Permisos") && ctx["Permisos"] is List<string> perms)
                {
                    if (perms.Contains("admin"))
                    {
                        return "Acceso Total Concedido (Admin).";
                    }
                    else if (perms.Contains("write") && perms.Contains("read"))
                    {
                        if (n > 8) return "Acceso Editor Senior.";
                        else return "Acceso Editor Junior.";
                    }
                    else
                    {
                        return "Acceso Lectura.";
                    }
                }
                else
                {
                    return "Error: Permisos mal formados.";
                }
            }
            else
            {
                return "Acceso nivel bajo.";
            }
        }
        else
        {
            // 4. Else final para la condición principal
            return "Usuario no autenticado o inválido.";
        }
    }
}