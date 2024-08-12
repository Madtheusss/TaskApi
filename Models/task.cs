using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace TaskApi.Models;
public class Task
{
    public int Id { get; set; } = default;
    public string Title { get; set; } = default;
    public string Description { get; set; } = default;
    public bool Conclued { get; set; } = default;

}
