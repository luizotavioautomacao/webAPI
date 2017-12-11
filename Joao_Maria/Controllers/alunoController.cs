using Joao_Maria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Joao_Maria.Controllers
{
    public class alunoController : ApiController
    {
        private static List<aluno> aluno = new List<aluno>();
        private static List<saida1> saida1 = new List<saida1>();

        public List<saida1> Get()
        {
            return saida1;            
        }

        public void Post(int dia, int maca, int pera)
        {
            if (ModelState.IsValid)
            {
                if ((dia <= 30) && (dia >= 1) && (maca >= 0) && (maca <= 5) && (pera >= 0) && (pera <= 5))
                {
                    aluno.Add(new aluno(dia, maca, pera));

                    ////////

                    if (dia % 2 == 0) // João > NOTA
                    {
                        if (maca >= 3)
                        {
                            saida1.Add(new saida1(1, "Maçã"));
                            saida1.Add(new saida1(2, "Maçã"));
                            saida1.Add(new saida1(3, "Maçã"));
                        }

                        else // maçã = 0,1 ou 2
                        {
                            switch (maca)
                            {
                                case 0:
                                    switch (pera)
                                    {
                                        case 0:
                                            saida1.Add(new saida1(1, ""));
                                            saida1.Add(new saida1(2, ""));
                                            saida1.Add(new saida1(3, ""));
                                            break;
                                        case 1:
                                            saida1.Add(new saida1(1, "Pera"));
                                            saida1.Add(new saida1(2, ""));
                                            saida1.Add(new saida1(3, ""));
                                            break;
                                        case 2:
                                            saida1.Add(new saida1(1, "Pera"));
                                            saida1.Add(new saida1(2, "Pera"));
                                            saida1.Add(new saida1(3, ""));
                                            break;
                                        default:
                                            saida1.Add(new saida1(1, "Pera"));
                                            saida1.Add(new saida1(2, "Pera"));
                                            saida1.Add(new saida1(3, "Pera"));
                                            break;
                                    }
                                    break;
                                case 1:
                                    switch (pera)
                                    {
                                        case 0:
                                            saida1.Add(new saida1(1, "Maçã"));
                                            saida1.Add(new saida1(2, ""));
                                            saida1.Add(new saida1(3, ""));
                                            break;
                                        case 1:
                                            saida1.Add(new saida1(1, "Maçã"));
                                            saida1.Add(new saida1(2, "Pera"));
                                            saida1.Add(new saida1(3, ""));
                                            break;
                                        default:
                                            saida1.Add(new saida1(1, "Maçã"));
                                            saida1.Add(new saida1(2, "Pera"));
                                            saida1.Add(new saida1(3, "Pera"));
                                            break;
                                    }
                                    break;
                                case 2:
                                    switch (pera)
                                    {
                                        case 0:
                                            saida1.Add(new saida1(1, "Maçã"));
                                            saida1.Add(new saida1(2, "Maçã"));
                                            saida1.Add(new saida1(3, ""));
                                            break;
                                        default:
                                            saida1.Add(new saida1(1, "Maçã"));
                                            saida1.Add(new saida1(2, "Maçã"));
                                            saida1.Add(new saida1(3, "Pera"));
                                            break;
                                    }
                                    break;
                            }
                        }
                    }

                    if (dia % 2 == 1) // Maria > NOTA
                    {
                        if (pera >= 3)
                        {
                            saida1.Add(new saida1(1, "Pera"));
                            saida1.Add(new saida1(2, "Pera"));
                            saida1.Add(new saida1(3, "Pera"));
                        }

                        else // pera = 0,1 ou 2
                        {
                            switch (pera)
                            {
                                case 0:
                                    switch (maca)
                                    {
                                        case 0:
                                            saida1.Add(new saida1(1, ""));
                                            saida1.Add(new saida1(2, ""));
                                            saida1.Add(new saida1(3, ""));
                                            break;
                                        case 1:
                                            saida1.Add(new saida1(1, "Maçã"));
                                            saida1.Add(new saida1(2, ""));
                                            saida1.Add(new saida1(3, ""));
                                            break;
                                        case 2:
                                            saida1.Add(new saida1(1, "Maçã"));
                                            saida1.Add(new saida1(2, "Maçã"));
                                            saida1.Add(new saida1(3, ""));
                                            break;
                                        default:
                                            saida1.Add(new saida1(1, "Maçã"));
                                            saida1.Add(new saida1(2, "Maçã"));
                                            saida1.Add(new saida1(3, "Maçã"));
                                            break;
                                    }
                                    break;
                                case 1:
                                    switch (maca)
                                    {
                                        case 0:
                                            saida1.Add(new saida1(1, "Pera"));
                                            saida1.Add(new saida1(2, ""));
                                            saida1.Add(new saida1(3, ""));
                                            break;
                                        case 1:
                                            saida1.Add(new saida1(1, "Pera"));
                                            saida1.Add(new saida1(2, "Maçã"));
                                            saida1.Add(new saida1(3, ""));
                                            break;
                                        default:
                                            saida1.Add(new saida1(1, "Pera"));
                                            saida1.Add(new saida1(2, "Maçã"));
                                            saida1.Add(new saida1(3, "Maçã"));
                                            break;
                                    }
                                    break;
                                case 2:
                                    switch (maca)
                                    {
                                        case 0:
                                            saida1.Add(new saida1(1, "Pera"));
                                            saida1.Add(new saida1(2, "Pera"));
                                            saida1.Add(new saida1(3, ""));
                                            break;
                                        default:
                                            saida1.Add(new saida1(1, "Pera"));
                                            saida1.Add(new saida1(2, "Pera"));
                                            saida1.Add(new saida1(3, "Maçã"));
                                            break;
                                    }
                                    break;
                            }
                        }
                    }

                    ////////
                }

                else
                {
                    BadRequest();
                }
                
                                                    
            }                          
        }
    }
}
