using Notes.Core.Budget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes;

class ComboItem
{
    private int id;
    private string title;

    public ComboItem(int id, string title)
    {
        this.id = id;
        this.title = title;
    }

    public override string ToString() => title;
    public Period getId() => (Period)id;
}
