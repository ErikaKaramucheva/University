#include <iostream>
using namespace std;
static int arr[10];
//(n*k)!/(n-k)! *m    m=3; n=6,k=2
int test1(int m, int n, int  k) {
	_asm {
		mov eax,n
		sub eax,k
		mov ecx,eax
		for:
		cmp ecx,1
			jle skip
			dec ecx
			mul ecx
			jmp for

			skip:
			mov ebx,eax
			mov eax,n
			mul k
			mov ecx,eax
			for2:
				cmp ecx,1
				jle second
				dec ecx
				mul ecx
				jmp for2


				second:
				mov edx,0
					div ebx
					mul m
					return:
	}
}
//n+k)!/sum(fibonacci(n+k)  *c
int test2(int n, int k, int c) {
	int sum = 0;
	_asm {
		mov eax,n
		add eax,k
		mov ecx,0
		mov [arr+4*ecx],1
		mov [arr+4+4*ecx],1
		for:
		cmp ecx,eax
			jge skip
			mov ebx,[arr+4*ecx]
			mov edx,[arr+4+4*ecx]
			add ebx,edx
			mov [arr+8+4*ecx],ebx
			inc ecx
			jmp for
			skip:
		mov ecx,0
			for2:
				cmp ecx,eax
				jge second
			mov ebx,[arr+4*ecx]
			add sum,ebx
			inc ecx
			jmp for2

			second:
		mov eax,n
			add eax,k
			mov ecx,eax
			for3:

	}
}
int main() {
	cout << test1(3, 6, 2) << endl;
}