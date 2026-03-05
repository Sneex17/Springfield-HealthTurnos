using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPresentacion.DecoratorPattern
{
    public interface IDataGridDecorator
    {
        void Aplicar(DataGridView viewData);
    }
}
