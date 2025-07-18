#include <iostream>
using namespace std;
static int arr[10];

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
		mov eax, a
		add eax,b
		add eax,c
		mov ecx, 3
		mov edx,0
		div ecx
		skip:
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
		skip:
	}
}
int sgn(int i) {
	_asm {
		mov eax,1
		cmp eax,i
		jle skip
		mov eax,-1
		cmp eax,i
		jge skip
		mov eax,0
		skip:

	}
}
int min3(unsigned char a, short b, int c) {
	_asm {
		movsx eax,a
		movsx ebx,b
		cmp eax,ebx
		jle skip
		movsx eax,ebx
		skip:
		cmp eax, c
			jle return
			mov eax, c
			return:
	}
}
int positive(int a, int b, int c) {
	_asm {
		mov eax,0
		cmp eax,a
		jge skip
		cmp eax,b
		jge skip
		cmp eax,c
		jge skip
		mov eax,1
		skip:
	}
}
int power(int n, unsigned int m) {
	_asm {
		mov eax,n
		mov ecx,m
		for:
		cmp ecx,1
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
		mov eax,-1
		cmp eax,a
		jge skip
		mov eax,1
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
		je return
		cmp eax,ebx
		jl skip
		mov result,-1
		jmp return
		skip:
		mov result,1
		return:

	}
	return result;
}
//3) Въведете 3 числа от клавиатурата, 
//изведете броя на положителните числа и сумата им;
void sum(int a, int b, int c) {
	int sum = 0;
	int count = 0;
	_asm {
		mov eax,0
		cmp eax,a
		jge skip
		inc count
		mov ebx,a
		add sum,ebx
		skip:
		cmp eax,b
		jge second 
		inc count
			mov ebx,b
		add sum, ebx
			second:
		cmp eax,c
			jge return
			inc count
			mov ebx,c
			add sum,ebx
			return:
	}
	cout << "Positive numbers: " << count << ". Sum= " << sum << endl;
}
//1) Напишете програма, която пресмята N!
void factorial(int n) {
	int result = 1;
	_asm {
		mov ecx,n
		mov eax,1
		for:
		cmp ecx,1
			jl skip
			mul ecx
			dec ecx
			jmp for
			
			skip:
			mov result, eax
	}
	cout << result;
}
//2) Напишете програма, която извежда 10 числа със стъпка 2 във вида : 2, 4, 6, 8, 10, 12, 14, 16, 18, 20
void step(int n) {
	_asm {
		mov eax,n
		mov ecx,0
		for:
		cmp ecx,10
			jge skip
			mov [arr+4*ecx],eax
			add eax,n
			inc ecx
			jmp for

			skip:

	}
	for (int i = 0; i < 10; i++) {
		cout << arr[i] << endl;
	}
}
// 3) Напишете програма, която
//отпечатва квадратите на масив с 10 числа.
void power() {
	_asm {
		mov ecx,0
		for:
		cmp ecx,10
			jge skip
			mov eax,[arr+4*ecx]
			mul eax
			mov [arr+4*ecx],eax
			inc ecx
		jmp for
		skip:
	}
	for (int i = 0; i < 10; i++) {
		cout << arr[i] << endl;
	}
}
/*5) Напишете програма, която сумира
първите
N члена от редицата на Фибоначи
*/
int fibSum(int n) {
	int sum = 0;
	_asm {
		mov ecx,0
		mov [arr+4*ecx],1
		inc ecx
		mov [arr+4*ecx],1
		mov ecx,0
		for:
		cmp ecx,n
			jge skip
			mov eax,[arr+4*ecx]
			add eax,[arr+4+4*ecx]
			mov [arr+8+4*ecx],eax
			inc ecx
			jmp for
			skip:
		mov ecx,0
			for2:
			cmp ecx,n
			jge return
			mov eax,[arr+4*ecx]
			add sum,eax
			inc ecx
			jmp for2
			return:

	}
	return sum;
}
//write a program to to check if number is even or odd
int evenNumber(int n) {
	_asm {
		mov eax,n
		mov ecx,2
		for:
		cmp eax,1
			jle skip
			sub eax,ecx
			jmp for
			skip:
	}
}
//Write a program that takes the value n as input, and finds the sum of
//all the odd numbers between 1 and 2n + 1, inclusive.
int oddSum(int n) {
	int sum = 0;
	_asm {
		mov eax,n
		mov ecx,2
		mul ecx
		add eax,1
		for:
		cmp eax,1
			jl skip
			add sum,eax
			sub eax,2
			jmp for
			skip:
		
	}
	return sum;
}
//Write a program that takes three numbers as input: x,y,z. Then it prints 1
//to the console if x < y < z.It prints 0 otherwise.
int smaller(int a, int b, int c) {
	_asm {
		mov eax,1
		mov ebx,a
		cmp ebx,b
		jge skip
		mov ebx,b
		cmp ebx,c
		jge skip
		jmp return
		skip:
		mov eax,0
			return:
	}
}
//fibonacci number- from user
int fib(int n) {
	_asm {
		mov ecx,0
		mov[arr+4*ecx],1
		inc ecx
		mov [arr+4*ecx],1
		mov ecx,0
		for:
		cmp ecx,n
			jge skip
			mov eax, [arr+4*ecx]
			mov ebx, [arr+4+4*ecx]
			add eax, ebx
			mov [arr+8+4*ecx],eax
			inc ecx
			jmp for
			skip:
	}
}
int fib2(int n) {
	_asm {
		mov eax,1
		mov ebx,1
		mov ecx,0
		for:
		cmp ecx,n
			jg skip
			add eax,ebx//2 3 5
			mov edx,ebx//1 2 
			mov ebx,eax//2 3
			mov eax,edx//1 2
			inc ecx
			jmp for
			skip:
	}
}
//Write a program that takes a number m as input, and prints back 1 to the
//console if m is a prime number.Otherwise, it prints 0.
/*int prime(int n) {
	_asm {
		mov eax,n
		dec eax,1
		mov ecx
		mov eax,n
		for:
		cmp ecx,1
			jle skip
			div ecx
			dec ecx
			jmp for
			skip:

	}
}*/
/*int prime(int m) {
	int prime = 0;
	_asm {
		mov ecx,n
		for:
		mov eax,n
		dec ecx
			cmp ecx,1
			je prime
			sub ecx,0
			jz notprime
			mov edx,0
			div ecx
			sub edx,0
			jz notprime
			cmp ecx,1
			jle for
			jmp return

			notprime:
		mov prime,0
			jmp return
			prime:
		mov prime,1
			return:
	}
}
*/
int cubeVolume(int a) {
	_asm {
		mov eax,a
		mul a
		mul a
		skip:
	}
}
//1) Въведете 3 числа от клавиатурата, изведете броя на положителните числа и сумата им;
void positive2(int a, int b, int c) {
	int positive_count = 0;
	int sum = 0;
	_asm {
		mov eax,0
		mov ebx,a
		cmp eax,ebx
		jge skip
		inc positive_count
		add sum,ebx
		skip:
		mov ebx,b
			cmp ebx,eax
			jle second
			inc positive_count
			add sum, ebx
			second:
		mov ebx,c
			cmp eax,ebx
			jge return
			inc positive_count
			add sum,ebx
			return:

	}
	cout << "Positive: " << positive_count << " Sum= " << sum;
}
//2) Намерете най - голямото число от 3, въведени от клавиатурата.
int max(int a, int b, int c) {
	int max = 0;
	_asm {
		mov eax,a
		mov ebx,b
		cmp eax,ebx
		jge skip
		mov eax,ebx
		skip:
		mov ebx,c
			cmp eax,ebx
			jge return
			mov eax,ebx
			return:
			mov max,eax
	}
	return max;
}
//3) Подредете 3 числа в низходящ ред с вложени if на асемблер.
int main() {
	//cout << avg_int(4, -3, 7) << endl;
	//cout << avg_short(4, -3, 7) << endl;
	//cout << sgn(-6) << endl;
	//cout << min3(10,3,6) << endl;
	//cout << positive(10,3,-6) << endl;
	//cout << power(2,10) << endl;
	//cout << pzn(0) << endl;
	//cout << compare(3,1) << endl;
	//sum(2,5, -8);
	//factorial(5);
	//cout << compare(3,1) << endl;
	//step(2);
	//power();
	//cout<<fibSum(10)<<endl;
	//cout<<evenNumber(1023)<<endl;
	//cout<<oddSum(5)<<endl;
	//cout<<smaller(1,20,5)<<endl;
	cout<<fib(5)<<endl;
	cout<<fib2(5)<<endl;
	cout<<cubeVolume(5)<<endl;
	positive2(2, -5, 3);
	cout << endl;
	cout<<max(2, 5, -3)<<endl;
}