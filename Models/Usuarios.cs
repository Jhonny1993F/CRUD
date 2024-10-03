using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class Usuarios
    {
        [Key]
        public int UsuarioID { get; set; }
        public string? Usuario { get; set; }
        [PasswordPropertyText]
        public string? contraseña { get; set; }
    }
}
