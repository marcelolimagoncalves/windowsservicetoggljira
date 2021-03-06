﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Topshelf;

namespace TogglJiraConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            HostFactory.Run(p =>
            {
                p.Service<Service>(s =>
                {
                    s.ConstructUsing(st => new Service());
                    s.WhenStarted(st => st.Start());
                    s.WhenStopped(sp => sp.Stop());
                });
                p.RunAsLocalService();

                p.SetDescription("Serviço de integração de horas trabalhadas entre Toggl e Jira");
                p.SetDisplayName("Horas Toggl Jira");
                p.SetServiceName("HorasTogglJira");
            });

        }
    }
}
