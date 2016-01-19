using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContracts
{
    public class TestUseful : IUseful
    {
        public string Name { get; set; }
        public int Id { get; set; }
        
        /// <summary>
        /// 喔FUCK 可打註解
        /// </summary>
        /// <param name="name">名字啊</param>
        /// <param name="id">認證</param>
        public void Initialize(string name, int id)
        {
            
        }

        public void Run() 
        {
            this.Id = 0;
        }
    }
}
