using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using Solution1.Module.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution1.Module.Views
{
    [NonPersistent, NavigationItem("Consultar Pedidos")]
    public class ConsultarPedido : BaseObject
    {
        private XPCollection<PedidoWeb> _pedidos;
        public ConsultarPedido (Session session) : base (session) { }

        public XPCollection<PedidoWeb> Pedidos
        {
            get { return new XPCollection<PedidoWeb>(Session); }
            set { SetPropertyValue("Pedidos", ref _pedidos, value); }
        }
    }
}
