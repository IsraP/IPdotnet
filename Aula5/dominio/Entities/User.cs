using System;
using System.Collections.Generic;
using System.Text;

namespace dominio.Entities {
    public class User {
        public int Id { get; set; }

        public String Nome { get; set; }

        public String Email { get; set; }

        public virtual Departamento Departamento { get; set; }

        public int DepartamentoId { get; set; }

        public void Update(User u){
            this.Nome = u.Nome;
            this.Email = u.Email;
            this.Departamento = u.Departamento;
            this.DepartamentoId = u.DepartamentoId;
        }

        public bool isAdmin {get; set;}
    }
}
