using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Options;

namespace Bruno1.Models;

public class Folha
{
    [Key]
	public String? folhaId { get; set; }

	public Double valor { get; set; } 
	public decimal quantidade { get; set; }
	public decimal mes { get; set; }
	public decimal ano { get; set; }
	public String? funcionarioId { get; set; }
}
