using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CproefLib
{
    class AppDbContext
    {
    }

    public AppDbContext() : base(@"Data Source=LAPTOP-FAC37MEN\SQLEXPRESS;Initial Catalog=CProef;Persist Security Info=True;User ID=cproef;Password=bryan")
    {

    }
}
