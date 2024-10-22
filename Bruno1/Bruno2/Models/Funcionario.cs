using System;
using System.ComponentModel.DataAnnotations;

namespace Bruno1.Models;

public class Funcionario
{  
    [Key]
	public String? cpf { get; set; }
    
	public String? nome { get; set; }

}
