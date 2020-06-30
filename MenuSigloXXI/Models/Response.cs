using System;
using System.Collections.Generic;
using System.Text;

namespace MenuSigloXXI.Models
{
    public class Response
    {
        public bool IsSuccess { get; set; } //si pudo o no pudo 
        public string Message { get; set; } //Explicación de porque no pudo
        public object Result { get; set; } //resultado en consola

    }
}
