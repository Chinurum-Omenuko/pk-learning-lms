using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Domain.ValueObjects
{
    [Keyless]
    public class Grade
    {
        protected Grade() { }
    }
}