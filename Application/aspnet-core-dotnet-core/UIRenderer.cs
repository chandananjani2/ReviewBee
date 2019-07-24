using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnet_core_dotnet_core
{
    public class UIRenderer
    {
        public static void RenderGraph()
        {
            RenderChart();
        }

        private static void RenderChart()
        {
            RenderCallGraph();
        }

        private static void RenderCallGraph()
        {
            Console.WriteLine("Draw call graph1");
        }
    }
}
