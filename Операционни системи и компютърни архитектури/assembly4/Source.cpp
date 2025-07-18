#include <iostream>
using namespace std;
static int arr[10];
static int Fib[10];

/*Write function int avg_int (int a, int b, int c) to calculate the average value of these three int numbers.
Try that it works correctly for both positive and negative numbers (including their mix).

Write the function short avg_short (short a, short b, short c) to calculate the average value of these three short numbers.
Try that it works correctly for both positive and negative numbers (including their mix).

Write function int sgn (int i), which returns values -1, 0, 1, depending on whether the value is negative, zero or positive.

Write function int min3 function (unsigned char a, short b, int c) that returns the smallest value
from these three passed parameters.

Write function int positive (int a, int b, int c), which returns 1 if all arguments are positive, otherwise 0.

Write function int power(int n, unsigned int m) returning the n to the power of m*/
int avg_int(int a, int b, int c) {
	_asm {
		mov eax,a
		add eax,b
		add eax,c
		mov ecx,3
		mov edx,0
		div ecx
	}
}
short avg_short(short a, short b, short c) {
	_asm {
		mov ax,a
		add ax,b
		add ax,c
		mov ecx,3
		mov edx,0
		div ecx
	}
}
int sgn(int i) {
	_asm {
		mov eax,0
		cmp eax,i
		je skip
		mov eax,1
		cmp eax,i
		jle skip
		mov eax,-1
		skip:
	}
}
int min3(unsigned char a, short b, int c) {
	_asm {
		movsx eax,a
		movsx ebx,b
		cmp eax,ebx
		jle skip
		movsx eax,b
		skip:
		cmp eax,c
			jle return
			movsx eax,c
			return:
	}
}
int positive(int a, int b, int c) {
	_asm {
		mov eax,0
		mov ebx,a
		cmp eax,ebx
		jge skip
		mov ebx,b
		cmp eax,ebx
		jge skip
		mov ebx,c
		cmp eax,ebx
		jge skip
		mov eax,1
		skip:
	}
}
int power(int n, unsigned int m) {
	_asm {
		mov eax,n
		mov ecx,m
		for:cmp ecx,1
			jle skip
			mul n
			dec ecx
			jmp for
			skip:
	}
}
/*1) Напишете на асемблер функция pzn(int a) която:
if ( a < 0 ){
	res = -1;
}else if ( a==0 ){
	res = 0;
}else if ( a>0 ){
	res = 1;
}*/
int pzn(int a) {
	_asm {
		mov eax,0
		cmp eax,a
		je skip
		mov eax,1
		cmp eax,a
		jle skip
		mov eax,-1
		skip:
	}
}
/*2) Напишете на асеблер фукнция compare(int a, int b) за която:
if (x<y){
	res = 1;
} else if( x>y ){
	res = -1;
}else if (x==y){
	res = 0;
} */
int compare(int a, int b) {
	int result = 0;
	_asm {
		mov eax,a
		mov ebx,b
		cmp eax,ebx
		je skip
		cmp eax,ebx
		jl second
		mov result,-1
		jmp return
		skip:
		mov result,0
		jmp return
		second:
		mov result,1
		return:


	}
	return result;
}
//3) Въведете 3 числа от клавиатурата, 
//изведете броя на положителните числа и сумата им;
void sum(int a, int b, int c) {
	int positive_count = 0;
	int sum = 0;
	_asm {
		mov ebx,a
		mov eax,0
		cmp eax,ebx
		jge skip
		add sum,ebx
			inc positive_count
			skip:
		mov ebx,b
			cmp eax,ebx
			jge second
			inc positive_count
			add sum,ebx
			second:
		mov ebx,c
			cmp eax,ebx
			jge return
			inc positive_count
			add sum,ebx
			return:

	}
	cout << "Positive numbers: " << positive_count << ". Sum= " << sum << endl;
}
//1) Напишете програма, която пресмята N!
int factorial(int n) {
	_asm {
		mov eax,1
		mov ecx,n
		for:
		cmp ecx,1
			jl return
			mul ecx
			dec ecx
			jmp for
			return:
	}
}
//2) Напишете програма, която извежда 10 числа със стъпка 2 във вида : 2, 4, 6, 8, 10, 12, 14, 16, 18, 20
void step(int n) {
	_asm {
		mov ecx,0
		mov eax,2
		for:
		cmp ecx,10
			jg return
			mov [arr+4*ecx],eax
			add eax,n
			inc ecx
			jmp for
			return:
	}
	for (int i=0; i <10; i++) {
		cout << arr[i] << ", ";
	}
}
// 3) Напишете програма, която
//отпечатва квадратите на масив с 10 числа.
void pow() {
	_asm {
		mov ecx,0
		for:
		cmp ecx,10
			jge return
			mov eax,[arr+4*ecx]
			mul eax
			mov [arr+4*ecx],eax
			inc ecx
			jmp for
			return:
	}
	for (int i = 0; i < 10; i++) {
		cout << arr[i] << endl;
	}
}
/*5) Напишете програма, която сумира
първите
N члена от редицата на Фибоначи
*/
int fibSum() {
	int sum = 2;
	_asm {
		mov ecx,0
		mov [Fib+4*ecx],1
		inc ecx
		mov[Fib+4*ecx],1
		mov ecx,0
		for:
		cmp ecx,10
			jge skip
			mov eax,[Fib+4*ecx]
			mov ebx,[Fib+4+4*ecx]
			add eax,ebx
			mov [Fib+8+4*ecx],eax
			add sum,eax
			inc ecx
			jmp for
			skip:
	}
	return sum;
}
//write a program to to check if number is even or odd
void evenOrOdd(int n) {
	int result = 0;
	_asm {
		mov eax,2
		mov ecx,n
		for:
		cmp ecx,1
			jle skip
			sub ecx,eax
			jmp for
			skip:
			mov result,ecx

	}
	cout << result;
}
//Write a program that takes the value n as input, and finds the sum of
//all the odd numbers between 1 and 2n + 1, inclusive.
int gitSum(int n) {
	int sum = 1;
	_asm {
		mov eax,n
		add eax,eax
		add eax,1
		mov ecx,2
		for:
		cmp eax,1
			jle skip
			add sum,eax
			sub eax,ecx
			jmp for
			skip:
	}
	return sum;
}
//Write a program that takes three numbers as input: x,y,z. Then it prints 1
//to the console if x < y < z.It prints 0 otherwise.
int compareNumbers(int x, int y, int z) {
	int result = 0;
	_asm {
		mov eax,x
		mov ebx,y
		cmp eax,ebx
		jge skip
		mov eax,z
		cmp ebx,eax
		jge skip
		mov result,1
		skip:
	}
	return result;
}
//fibonacci number- from user
int fib(int n) {
	int result = 0;
	_asm {
		mov eax,1
		mov ebx,1
		mov ecx,n
		for:
		cmp ecx,1
			jle skip
			add eax,ebx
			mov edx,ebx
			mov ebx,eax
			mov eax,edx
			dec ecx
		jmp for
			skip:
		mov result,ebx
	}
	return result;
}
//Write a program that takes a number m as input, and prints back 1 to the
//console if m is a prime number.Otherwise, it prints 0.
int prime(int m) {
	_asm {
		mov eax,m
		mov ecx,m
		su ecx,1
		for:
		cmp ecx,1
			jle skip
			div ecxjmp for
			skip:
	}
}
//Write a program that takes the number n as input. Then it prints all the
//numbers x below n that have exactly 2 different integral divisors(Besides 1
//	and x).

int main() {
	//cout << avg_int(3, 6, 12) << endl;
	//cout << avg_short(3,- 6, 12) << endl;
	//cout << min3(3, 6, -12) << endl;
	//cout << positive(3, -6, 12) << endl;
	//cout << sgn(9) << endl;
	//cout << power(3,3) << endl;
	//cout << pzn(0) << endl;
	//sum(3, -2, -9);
	//cout<< factorial(4)<<endl;
	//step(2);
	//cout << endl;
	//pow();
	//cout << fibSum() << endl;
	//for (int i = 0; i < 10; i++) {
	//	cout << Fib[i] << endl;
	//}
	//evenOrOdd(10);
	//cout <<gitSum(3)<< endl;
	//cout <<compareNumbers(4,-5,6)<< endl;
	cout <<fib(4)<< endl;
}