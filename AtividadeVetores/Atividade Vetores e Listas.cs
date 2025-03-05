namespace AtividadeVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O menu ----");
            MenuPrincipalAtividades();
        }
        //Seletores ------------------------------------------------
        static int EscolhaInt(string pergunta)
        {
            string numero;
            if (!string.IsNullOrEmpty(pergunta))
            {
                Console.WriteLine(pergunta);
            }

            while (true)
            {
                try
                {
                    numero = Console.ReadLine();

                    if (int.TryParse(numero, out int result))
                    {
                        return Convert.ToInt32(numero);
                    }
                    else
                    {
                        throw new Exception("Valor invalido!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        static string EscolhaString(string pergunta)
        {
            string resposta;
            if (!string.IsNullOrEmpty(pergunta))
            {
                Console.WriteLine(pergunta);
            }
            
            while (true)
            {
                try
                {
                    resposta = Console.ReadLine();

                    if (!string.IsNullOrEmpty(resposta))
                    {
                        return resposta;
                    } 
                    else
                    {
                        throw new Exception("Resposta vazia!");
                    }
                } catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
        }
        //Menus ------------------------------------------------
        static void MenuPrincipalAtividades()
        {
            bool ativo = true;
            do
            {
                Console.WriteLine("____________Menu____________");
                Console.WriteLine("Escolha uma lista: ");
                Console.WriteLine("1 - Atividade Vetores");
                Console.WriteLine("2 - Atividade List");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("");

                int opcao = EscolhaInt("Escolha uma opção");

                switch (opcao)
                {
                    case 1:
                        SubMenuVetores();
                        break;

                    case 2:
                        SubMenuListas();
                        break;

                    case 0:
                        Console.WriteLine("Saindo... Até!");
                        ativo = false;
                        break;

                    default:
                        Console.WriteLine("Opção invalida");
                        break;

                }

            } while (ativo);
        }

        static void SubMenuVetores()
        {
            bool ativo = true;
            do
            {
                Console.WriteLine("____________Vetores____________");
                Console.WriteLine("Escolha uma Atividade: ");
                Console.WriteLine("1 - Soma e Mêdia");
                Console.WriteLine("2 - Maior e Menor");
                Console.WriteLine("3 - Pares e Ímpares");
                Console.WriteLine("4 - Busca por valor");
                Console.WriteLine("5 - Inverter de vetor");
                Console.WriteLine("6 - Quantas vezes repetiu");
                Console.WriteLine("7 - Mescla de valores");

                Console.WriteLine("0 - Sair");
                Console.WriteLine("");

                int opcao = EscolhaInt("Escolha uma opção");

                switch (opcao)
                {
                    case 1:
                        AtividadeVetor1();
                        break;

                    case 2:
                        AtividadeVetor2();
                        break;

                    case 3:
                        AtividadeVetor3();
                        break;

                    case 4:
                        AtividadeVetor4();
                        break;

                    case 5:
                        AtividadeVetor5();
                        break;

                    case 6:
                        AtividadeVetor6();
                        break;

                    case 7:
                        AtividadeVetor7();
                        break;

                    case 0:
                        ativo = false;
                        break;

                    default:
                        Console.WriteLine("Opção invalida");
                        break;

                }

            } while (ativo);


        }

        static void SubMenuListas()
        {
            bool ativo = true;
            do
            {
                Console.WriteLine("____________Vetores____________");
                Console.WriteLine("Escolha uma Atividade: ");
                Console.WriteLine("1 - Numeros de 1 a 5");
                Console.WriteLine("2 - Soma total");
                Console.WriteLine("3 - Encontrar maior valor");
                Console.WriteLine("4 - Remova frutas");
                Console.WriteLine("5 - Quais são maiores de 50?");
                Console.WriteLine("6 - O nome está presente?");
                Console.WriteLine("7 - Remover o primeiro e ultimo");

                Console.WriteLine("0 - Sair");
                Console.WriteLine("");

                int opcao = EscolhaInt("Escolha uma opção");

                switch (opcao)
                {
                    case 1:
                        AtividadeList1();
                        break;

                    case 2:
                        AtividadeList2();
                        break;

                    case 3:
                        AtividadeList3();
                        break;

                    case 4:
                        AtividadeList4();
                        break;

                    case 5:
                        AtividadeList5();
                        break;

                    case 6:
                        AtividadeList6();
                        break;

                    case 7:
                        AtividadeList7();
                        break;

                    case 0:
                        ativo = false;
                        break;

                    default:
                        Console.WriteLine("Opção invalida");
                        break;

                }

            } while (ativo);


        }


        //Funçoes Atividade Vetores ------------------------------------------------
        static int SomarVetor(int[] numeros)
        {
            int somaTotal = 0;
            for (int i = 0; i < numeros.Length; i++)
            { 
                somaTotal += numeros[i];
            }
            return somaTotal;
        }
        static int MediaVetor(int[] numeros)
        {
           return (SomarVetor(numeros) / numeros.Length);
        }
        static int MaiorValorVetor(int[] numeros)
        {
            int maior = numeros[0]; 


            for (int i = 0; i < numeros.Length; i++)
            {
                if (maior < numeros[i])
                {
                    maior = numeros[i];
                } 
            }
            return maior;
        }
        static int MenorValorVetor(int[] numeros)
        {
            int menor = numeros[0];


            for (int i = 0; i < numeros.Length; i++)
            {
                if (menor > numeros[i])
                {
                    menor = numeros[i];
                }
            }
            return menor;
        }
        static int[] CapturarParesVetor(int[] numeros)
        {
            int tamanho = -1;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    tamanho += 1;
                }
            }
            if (!(tamanho < 0))
            {
                int[] pares = new int[tamanho + 1];
                int j = 0;

                for (int i = 0; i < numeros.Length; i++)
                {
                    if (numeros[i] % 2 == 0)
                    {
                        pares[j] = numeros[i];
                        j++;
                    }
                }
                return pares;
            }
            else
            {
                return new int[0];
            }
        }
        static int[] CapturarImparesVetor(int[] numeros)
        {
            int tamanho = -1;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 != 0)
                {
                    tamanho += 1;
                }
            }
            if (!(tamanho < 0))
            {
                int[] pares = new int[tamanho + 1];
                int j = 0;

                for (int i = 0; i < numeros.Length; i++)
                {
                    if (numeros[i] % 2 != 0)
                    {
                        pares[j] = numeros[i];
                        j++;
                    }
                }
                return pares;
            }
            else
            {
                return new int[0];
            }
        }
        static bool EncontrarValor(int[] numeros, int procurado) 
        {
            bool encontrado = false;

            for (int i = 0;i < numeros.Length;i++)
            {
                if (numeros[i].Equals(procurado))
                {
                    encontrado = true;
                }
            }
            
            return encontrado;
        
        }
        static int[] InverterVetor(int[] vetor)
        {
            int[] vetorInvertido = new int[vetor.Length];
            int j = vetorInvertido.Length -1;


            for (int i = 0; i < vetor.Length; i++)
            {
                vetorInvertido[j] = vetor[i];
                j--;
            }

            return vetorInvertido;
        }
        static int QuantasVezes(int[] vetor, int procurado)
        {
            int vezes = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i].Equals(procurado))
                {
                    vezes++;
                }
            }
            return vezes;
        }
        static int[] OrganizarCrescente(int[] vetor)
        {
            int aux = 0;
            
            for (int i = 0;i < vetor.Length; i++)
            {
                for (int j = i; j < vetor.Length; j++)
                {
                    if (vetor[i] > vetor[j])
                    {
                        aux = vetor[i];
                        vetor[i] = vetor[j];
                        vetor[j] = aux;

                    }
                }
            }

            return vetor;
        }
        static int[] MesclarVetores(int[] vetorUm, int[] vetorDois)
        {
            int tamanho = (vetorUm.Length + vetorDois.Length);
            int[] vetorMesclado = new int[tamanho];
            int iterMes = 0;

            for (int i = 0; i < vetorUm.Length; i++)
            {
                vetorMesclado[iterMes] = vetorUm[i];
                iterMes++;
            }
            for (int i = 0; i < vetorDois.Length; i++)
            {
                vetorMesclado[iterMes] = vetorDois[i];
                iterMes++;
            }

            return vetorMesclado;
        }

        
        
        //Main Atividade VETORES ------------------------------------------------
        static void AtividadeVetor1()
        {
            int[] vetorNumeros = new int[5];

            for (int i = 0;i < vetorNumeros.Length;i++) 
            {
                vetorNumeros[i] = EscolhaInt("Insira um valor no vetor");
            }

            Console.WriteLine("A soma de todos os numeros é {0}", SomarVetor(vetorNumeros));
            Console.WriteLine("E a mêdia é {0}", MediaVetor(vetorNumeros));

        }
        static void AtividadeVetor2()
        {
            int[] vetorNumeros = new int[5];

            for (int i = 0; i < vetorNumeros.Length; i++)
            {
                vetorNumeros[i] = EscolhaInt("Insira um valor no vetor");
            }

            Console.WriteLine("O maior valor é {0}", MaiorValorVetor(vetorNumeros));
            Console.WriteLine("O menor valor é {0}", MenorValorVetor(vetorNumeros));
        }
        static void AtividadeVetor3()
        {
            int[] vetorNumeros = new int[6];

            for (int i = 0; i < vetorNumeros.Length; i++)
            {
                    vetorNumeros[i] = EscolhaInt("Insira um valor no vetor");
            }

            Console.WriteLine("Os pares são: ");
            int[] pares = CapturarParesVetor(vetorNumeros);
            for (int i = 0; i < pares.Length; i++)
            {
                Console.Write("{0}, ", pares[i]);
            }
           
            Console.WriteLine("\nOs impares são: ");

            int[] impares = CapturarImparesVetor(vetorNumeros);
            for (int i = 0; i < impares.Length; i++)
            {
                Console.Write("{0}, ", impares[i]);
            }
            Console.WriteLine("");
        }
        static void AtividadeVetor4()
        {
            int[] vetorNumeros = new int[6];

            for (int i = 0; i < vetorNumeros.Length; i++)
            {
                vetorNumeros[i] = EscolhaInt("Insira um valor no vetor");
            }

            int numeroProcurar = EscolhaInt("Digite um numero que deseja encontra no vetor");
            string resposta = EncontrarValor(vetorNumeros, numeroProcurar) ? 
                              "Numero encontrado" : "Numero não encontrado";

            Console.WriteLine(resposta);
        }
        static void AtividadeVetor5()
        {
            int[] vetorNumeros = new int[6];

            for (int i = 0; i < vetorNumeros.Length; i++)
            {
                vetorNumeros[i] = EscolhaInt("Insira um valor no vetor");
            }

            Console.WriteLine("O vetor invertido é");
            int[] vetorInvertido = InverterVetor(vetorNumeros);

            for (int i = 0; i < vetorInvertido.Length; i++)
            {
                Console.Write("{0}, ", vetorInvertido[i]);
            }
            Console.WriteLine("");
        }
        static void AtividadeVetor6()
        {
            int[] vetorNumeros = new int[6];

            for (int i = 0; i < vetorNumeros.Length; i++)
            {
                vetorNumeros[i] = EscolhaInt("Insira um valor no vetor");
            }

            int numeroProcurar = EscolhaInt("Digite um numero que deseja encontra no vetor");

            Console.WriteLine("Esse numero foi encontrado {0} vezes", QuantasVezes(vetorNumeros, numeroProcurar));
        }
        static void AtividadeVetor7()
        {
            Console.WriteLine("Preencha o primeiro vetor");
            int[] vetorNumeros = new int[6];

            for (int i = 0; i < vetorNumeros.Length; i++)
            {
                vetorNumeros[i] = EscolhaInt("Insira um valor no vetor");
            }
            Console.WriteLine("Preencha o segundo vetor");
            int[] vetorNumerosDois = new int[6];

            for (int i = 0; i < vetorNumeros.Length; i++)
            {
                vetorNumerosDois[i] = EscolhaInt("Insira um valor no vetor");
            }
            int[] mesclado = MesclarVetores(vetorNumeros, vetorNumerosDois);
            OrganizarCrescente(mesclado);

            Console.WriteLine("O vetor resultante é");
            for (int i = 0; i < mesclado.Length; i++)
            {
                Console.Write("{0}, ", mesclado[i]);
            }
            Console.WriteLine("");

        }
        //Funçoes Atividade List ------------------------------------------------
        static int SomarLista(List<int> numeros)
        {
            int somaTotal = 0;

            foreach (int i in numeros)
            {
                somaTotal += i;
            }

            return somaTotal;
        }

        static int EncontrarMaiorValorLista(List<int> numeros)
        {
            int maior = 0;

            foreach (int i in numeros)
            {
                if (i > maior) { maior = i; }
            }

            return maior;
        }

        static List<int> MaioresQue50(List<int> numeros)
        {
            List<int> maiores = new List<int>();
            foreach (int i in numeros)
            {
                if (i > 50)
                {
                    maiores.Add(i);
                }
            }
            return maiores;
        }

        static List<int> RemoverPrimeiroeUltimo(List<int> numeros) 
        {
            numeros.RemoveAt(0);
            numeros.RemoveAt(numeros.Count - 1);

            return numeros;
        }

        //Main Atividade List ------------------------------------------------
        static void AtividadeList1()
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine("Exibindo Numeros: ");

            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }
        }    

        static void AtividadeList2()
        {
            List<int> numeros = new List<int> { 1, 4, 5, 6, 3 };
            Console.WriteLine("A lista é:");
            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("");
            Console.WriteLine("Adicione mais 5 numeros a lista:");
            int escolha = 0;
            for (int i = 0; i < 5; i++)
            {
                escolha = EscolhaInt("");
                numeros.Add(escolha);
            }

            Console.WriteLine("Nova lista: ");
            foreach (int i in numeros)
            {
                Console.Write("{0},", numeros[i - 1]);
            }
            Console.WriteLine("");
            Console.WriteLine("A soma é: {0}", SomarLista(numeros));
            
        }

        static void AtividadeList3()
        {
            List<int> numeros = new List<int> { 1, 5, 4, 2, 1, 7 };

            Console.WriteLine("O maior numero é {0}", EncontrarMaiorValorLista(numeros));
        }

        static void AtividadeList4()
        {
            List<String> frutas = new List<String> { "laranja", "limão", "maçã", "banana", "uva", "abacate", "tangerina" };

            Console.WriteLine("Lista de frutas: ");
            foreach(string i in frutas)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("");
            
            string escolha = EscolhaString("");
            bool encontrado = false;

            for (int i = 0; i < frutas.Count; i++)
            {
                if (escolha.Equals(frutas[i], StringComparison.OrdinalIgnoreCase))
                {
                    encontrado = true;
                    frutas.Remove(frutas[i]);
                    continue;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("Produto não encontrado.");
            }
            else
            {
                Console.WriteLine("--------- Lista atualizada --------- ");
                foreach (string i in frutas)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("");
            }
        }

        static void AtividadeList5()
        {
            List<int> numeros = new List<int>();

            Console.WriteLine("Adicione 10 numeros a lista:");
            int escolha = 0;
            for (int i = 0; i < 10; i++)
            {
                escolha = EscolhaInt("");
                numeros.Add(escolha);
            }

            List<int> maiores = MaioresQue50(numeros);

            Console.WriteLine("Os numeros maiores que 50 são: ");

            foreach(int i in maiores)
            {
                Console.Write("{0}, ", i);
            }
            Console.WriteLine("");
        }

        static void AtividadeList6()
        {
            List<string> nomes = new List<string> {"Rafael", "Jonas", "João", "Eduardo", "Diana", "Maria", "Ana", "Beatriz"};

            string nomeProcurar = EscolhaString("Informe o nome que deseja encontrar: ");
            bool encontrado = false;

            for (int i = 0; i < nomes.Count; i++)
            {
                if (nomeProcurar.Equals(nomes[i], StringComparison.OrdinalIgnoreCase))
                {
                    encontrado = true;
                    Console.WriteLine("A pessoa de nome {0}, Foi encontrada",nomeProcurar);
                    continue;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("Nome não encontrado.");
            }
        }

        static void AtividadeList7()
        {
            List<int> elementos = new List<int> { 1,2,3,4,5 };
            Console.WriteLine("A lista agora é");
            foreach (int i in elementos)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Removendo primeiro e ultimo");
            RemoverPrimeiroeUltimo(elementos);
            Console.WriteLine("Nova lista: ");
            foreach (int i in elementos)
            {
                Console.WriteLine(i);
            }

        }
    }
}