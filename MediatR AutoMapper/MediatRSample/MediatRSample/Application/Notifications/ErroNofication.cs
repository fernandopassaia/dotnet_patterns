using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace MediatRSample.Application.Notifications
{
    public class ErroNotification : INotification
    {
        public string Excecao { get; set; }
        public string PilhaErro { get; set; }
    }

}
