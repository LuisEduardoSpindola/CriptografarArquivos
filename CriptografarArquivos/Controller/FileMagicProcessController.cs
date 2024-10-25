using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace CriptografarArquivos.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileMagicProcessController : ControllerBase
    {
        private readonly byte[] key = Encoding.UTF8.GetBytes("ongapo0563049fdakf");
        private readonly byte[] _iv = Encoding.UTF8.GetBytes("");

    }
}
