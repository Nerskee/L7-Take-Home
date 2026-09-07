using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace L7_Take_Home.Models;

public class Exercize
{
    [Key]
    public int Id { get; set; }
    
    [Display(Name = "Activity Completed")]
    public string Name { get; set; }
    
    [Display(Name = "Date Completed")]
    public string Date { get; set; }
}