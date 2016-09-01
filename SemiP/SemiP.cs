using System;
class SemiP{
		public static int Absoluto (int n) {
		 
			if (n >= 0){
				return n;
			}else{
				return (n * -1);
			}
			
		}
		 
		public static void Main(string[] args){
			int n=0;
				
				for( int i=0; i <10; i++){
					
					Console.Write("digite um numero: ");
					n= int.Parse(Console.ReadLine());
					n= Absoluto(n);
					
					Console.Write("O absoluto do numero informado é: "+ n + "\n\n");
				}
				Console.WriteLine();
			
			
		}
	
}