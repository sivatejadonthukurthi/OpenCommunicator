using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2WayMessenger.Model
{
    public class ExceptionLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string? ExceptionMessage { get; set; }
        public string? StackTrace { get; set; }
        public string? ApiName { get; set; }
        public string? RepositoryName { get; set; }
        public DateTime Date { get; set; }
    }
    
}
