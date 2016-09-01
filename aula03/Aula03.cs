		using System;
class aula03{

					 static float mult(float x, float y){
						 
							return x * y ;
						}
				
					 static float soma(float num1, float num2){
						
							return num1 + num2;
						}
					static float div(float num1, float num2){
						
							return num1 / num2;
						}
					static float sub(float num1, float num2){
						
							return num1 - num2;
						}

				public static void Main(){
				
					int op= 0;
					float num1 = 0;
					float num2 = 0; 
					float resp = 0;
				
					do{
						Console.WriteLine("Escolha uma opcao a baixo: ");
						Console.WriteLine("\n1- Multiplicacao; \n2- Soma; \n3- Divisão; \n4- Subtração; \n5- Sair");
						do{
							op = int.Parse(Console.ReadLine());
								if((op < 1) || (op > 5))
									Console.WriteLine("Opção invalida");
						}while ((op <1) || (op > 5));
					
						if (op != 5){
							Console.WriteLine("Digite um numero: ");
							num1 = float.Parse(Console.ReadLine());
							Console.WriteLine("Digite outro numero: ");
							num2 = float.Parse(Console.ReadLine());
						}
					
						switch (op){
							case 1:
								resp = mult(num1, num2);
								break;
							case 2:
								resp = soma(num1, num2);
								break;
							case 3:
								resp = div(num1, num2);
								break;
							case 4:
								resp = sub(num1, num2);
								break;
						}
				
						if (op==5)
							Console.WriteLine("Programa encerado... ");
						else
							Console.WriteLine("Resultado da operação é: " + resp);
					}while(op !=5);
				}	
			}		
		//nome = Console.ReadLine()