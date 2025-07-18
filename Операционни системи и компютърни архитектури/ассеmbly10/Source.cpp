#include<iostream>
using namespace std;
static int arr[25];
static int arrays[10] = { 3,6,7,-1,4,2,1,5,-3,8 };

int add(int a, int b) {
	_asm {
		movsx eax,a
		add eax,b
		return:
	}
}
int power(int a) {
	_asm {
		movsx eax,a
		mul eax
		return:
	}
}
int abss(int a) {
	_asm {
		movsx eax,a
		cmp eax,0
		jge return
		neg eax
		return:
	}
}
int square_perimeter(int a) {
	_asm {
		mov eax,a
		mov ecx,4
		mul ecx
		return:
	}
}
int triangle_perimeter(int a, int b, int c) {
	_asm {
		movsx eax,a
		add eax,b
		add eax,c
		return:
	}
}
int rectangle_perimeter(int a, int b) {
	_asm {
		mov eax,a
		add eax,a
		add eax,b
		add eax,b
		return:

	}
}
int rectangle_area(int a, int b) {
	_asm {
		mov eax,a
		mul b
		return:
	}
}
void positiveSumAndCount(int a, int b, int c) {
	int count = 0;
	int sum = 0;
	_asm {
		mov eax,0
		movsx ebx,a
		cmp eax,ebx
		jge skip
		inc count
		add sum, ebx
		skip:
		movsx ebx,b
			cmp eax,ebx
			jge first
		inc count
			add sum,ebx
			first:
		movsx ebx,c
			cmp eax,ebx
			jge return
			inc count
			add sum,ebx
			return:
	}
	cout << "Positive numbers count: " << count << ". Sum= " << sum << endl;
}
void negativeAndSum(int a, int b, int c) {
	int count = 0;
	int sum = 0;
	_asm {
		mov eax,0
		movsx ebx,a
		cmp eax,ebx
		jle skip
		inc count
		add sum,ebx
		skip:
		movsx ebx,b
			cmp eax,ebx
			jle second
			inc count
			add sum,ebx
			second:
		movsx ebx,c
			cmp eax,ebx
			jle return
			inc count
			add sum,ebx
			return:
	}
	cout << "Negative numbers count= " << count << ". Sum= " << sum << endl;
}
int avg(int a, int b, int c, int d) {
	_asm {
		movsx eax,a
		add eax,b
		add eax,c
		add eax,d
		mov ecx,4
		mov edx,0
		div ecx
		return:
	}
}
int min_number(int a, int b, int c) {
	_asm {
		mov eax,a
		mov ebx,b
		cmp eax,ebx
		jle skip
		mov eax,ebx
		skip:
		mov ebx,c
			cmp eax,ebx
			jle return
			mov eax,ebx
			return:
	}
}
int max_number(int a, int b, int c, int d) {
	_asm {
		movsx eax,a
		movsx ebx,b
		cmp eax,ebx
		jge skip
		mov eax,ebx
		skip:
		movsx ebx,c
			cmp eax,ebx
			jge second
			mov eax,ebx
			second:
		movsx ebx,d
			cmp eax,ebx
			jge return
			mov eax,ebx
			return:
	}
}
int substract(int a, int b) {
	_asm {
		movsx eax,a
		sub eax,b
		return:
	}
}
int multiply(int a, int b) {
	_asm {
		movsx eax,a
		mul b
		return:
	}
}
int avg_int(int a, int b, int c) {
	_asm {
		movsx eax,a
		add eax,b
		add eax,c
		mov ecx,3
		mov edx,0
		div ecx
		return:
	}
}
short avg_short(short a, short b, short c) {
	_asm {
		movsx ax,a
		add ax,b
		add ax,c
		mov ecx,3
		mov edx,0
		cwd
		div ecx
		return:
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
int perimeter_of_rectangle(int a, int b) {
	_asm {
		mov eax,a
		add eax,a
		add eax,b
		add eax,b
		return:
	}
}
int area_of_rectangle(int a, int b) {
	_asm {
		mov eax,a
		mul b
		return:
	}
}
int perimeter_of_square(int a) {
	_asm {
		mov eax,a
		mov ecx,4
		mul ecx
		return:
	}
}
int area_of_square(int a) {
	_asm {
		mov eax,a
		mul a
		return:
	}
}
int perimeter_of_triangle(int a, int b, int c) {
	_asm {
		mov eax,a
		add eax,b
		add eax,c
		return:
	}
}
int perimeter_of_triangle2(int a) {
	_asm {
		mov ecx,3
		mov eax,a
		mul ecx
		return:
	}
}
int perimeter_of_triangle3(int a, int b) {
	_asm {
		mov eax,a
		add eax,a
		add eax,b
		return:
	}
}
int perimeter_of_triangle4(int a, int h) {
	_asm {
		mov eax,a
		add eax,a
		add eax,h
		return:
	}
}
int area_of_cube(int a){
	_asm {
		mov eax,a
		mul a
		mov ecx,6
		mul ecx
		return:
	}
	}
int compare(int a, int b) {
	_asm {
		mov eax,0
		mov ebx,a
		cmp ebx,b
		je return
		mov eax,1
		cmp ebx,b
		jle return
		mov eax,-1
		return:
	}
}
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
int power(int n, unsigned int m) {
	_asm {
		movsx eax,n
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
int positive(int a, int b, int c) {
	_asm {
		mov eax,0
		cmp eax,a
		jge return
		cmp eax,b
		jge return
		cmp eax,c
		jge return
		mov eax,1
		return:
	}
}
int min3(unsigned char a, short b, int c) {
	_asm {
		mov al,a
		movsx bx,b
		cbw
		cmp ax,bx
		jle skip
		mov ax,bx
		skip:
		cwde 
			movsx ebx,c
			cmp eax,ebx
			jle second
			mov eax,ebx
			second:

	}
}
int factorial(int n) {
	_asm {
		mov eax,1
		mov ecx,n
		for:
		cmp ecx,1
			jle skip
			mul ecx
			dec ecx
			jmp for
			skip:


	}
}
void step(int a) {
	_asm {
		mov eax,a
		mov ecx,0
		for:
		cmp ecx,10
			jge skip
			mov [arr+4*ecx],eax
			add eax,a
			inc ecx
			jmp for
			skip:
	}
	for (int i = 0; i < 10; i++) {
		cout << arr[i] << endl;
	}
}
void quadrat() {
	_asm {
		mov ecx,0
		for:
		cmp ecx,10
			jge skip
			mov eax, [arr+4*ecx]
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
int fibSum(int n) {
	_asm {
		mov ecx,0
		mov [arr+4*ecx],1
		mov [arr+4+4*ecx],1
		for:
		cmp ecx,n
			jg skip
			mov eax,[arr+4*ecx]
			mov ebx,[arr+4+4*ecx]
			add eax,ebx
			mov [arr+8+4*ecx],eax
			inc ecx
			jmp for
			skip:
		mov eax,0
		mov ecx,0
			for2:
			cmp ecx,n
			jg return
			mov ebx,[arr+4*ecx]
			add eax,ebx
			inc ecx
			jmp for2
			return:

	}
}
void fibonacci() {
	_asm {
		mov ecx,0
		mov [arr+4*ecx],1
		mov [arr+4+4*ecx],1
		for:
		cmp ecx,15
			jge return
			mov eax,[arr+4*ecx]
			add eax,[arr+4+4*ecx]
			mov [arr+8+4*ecx],eax
			inc ecx
			jmp for

			return:
	}
	for (int i = 0; i < 15; i++) {
		cout << arr[i] << endl;
	}
}
void countdown() {
	_asm {
		mov ecx,0
		mov eax,10
		for:
		cmp ecx,10
			jge return
			mov [arr+4*ecx],eax
			dec eax
			inc ecx
			jmp for
			return:
	}
	for (int i = 0; i < 10; i++) {
		cout << arr[i] << endl;
	}
}
void counter() {
	_asm{
		mov ecx,0
		for:
		cmp ecx,25
			jge skip
			mov [arr+4*ecx],ecx
			inc ecx
			jmp for

			skip:
	}
	for (int i = 0; i < 25; i++) {
		cout << arr[i] << endl;
	}
}
int min_element() {
	_asm {
		mov ecx,0
		mov eax,[arrays+4*ecx]
		inc ecx
		for:
		cmp ecx,10
			jge skip
		mov ebx,[arrays+4*ecx]
			inc ecx
			cmp eax,ebx
			jle for
			mov eax,ebx
			jmp for
			skip:
	}
}
int grade(int a, int b) {
	_asm {
		mov eax,a
		cmp eax,b
		jge skip
		mov eax,b
		skip:
	}
}
int max_element() {
	_asm {
		mov ecx,0
		mov eax,[arrays+4*ecx]
		inc ecx
		for:
		cmp ecx,10
			jge return
			mov ebx,[arrays+4*ecx]
			inc ecx
			cmp eax,ecx
			jge for
			mov eax,ebx
			jmp for


			return:
	}
}
int average(int a, int b, int c) {
	_asm {
		movsx eax,a
		add eax,b
		add eax,c
		mov ecx,3
		mov edx,0
		div ecx
		return:
	}
}
int example(int a, int b) {//a^3b +5b^2
	_asm{
		mov eax,a
		mul a
		mul a
		mul b
		mov ebx,eax
		mov eax,b
		mul b
		mov ecx,5
		mul ecx
		add eax,ebx
		return:
	}
}
int evenOrOdd(int n) {
	_asm {
		mov eax,n
		mov ecx,2
		for:
		cmp eax,1
			jle skip
			mov edx, 0
			sub eax,ecx
			jmp for
			skip:
	}
}
int oddAndSum(int n) {
	_asm {
		mov ecx,n
		add ecx,n
		add ecx,1
		mov eax,1
		for:
		cmp ecx,1
			jle return
			add eax, ecx
			sub ecx,2
		jmp for
		return:

	}
}
void evenNumbers(int n) {
	_asm {
		mov eax,n
		add eax,n
		mov ecx,0
		for:
		cmp ecx,n
			jg skip
			mov [arr+4*ecx],eax
			sub eax,2
			inc ecx
			jmp for

			skip:

	}
	for (int i = 0; i <25; i++) {
		cout << arr[i] << endl;
	}
}
int cmp(int x, int y, int z) {//x<y<z
	_asm {
		mov eax,0
		movsx ebx,y
		cmp x, ebx
		jge skip
		cmp ebx,z
		jge skip
		mov eax,1
		skip:
	}
}
void fib(int n) {
	_asm {
		mov ecx,0
		mov [arr+4*ecx],1
		mov [arr+4+4*ecx],1
		for:
		cmp ecx,n
			jg skip
			mov eax,[arr+4*ecx]
			mov ebx,[arr+4+4*ecx]
			add eax,ebx
			mov [arr+8+4*ecx],eax
			inc ecx
			jmp for
			skip:

	}
	cout << arr[n] << endl;
	for (int i = 0; i < 10; i++) {
		cout << arr[i] << endl;
	}
}
int prime_number(int n) {
	_asm {
		mov ecx,n
		for:
		mov eax, n
		cmp ecx,1
			jle skip
			mov edx,0
			div ecx
			dec ecx
			cmp eax,1
			je skip
			jmp for

			skip:
	}
	
}
int calculate(int m, int n, int k) {
	_asm {
		mov eax,n
		sub eax,k
		mov ecx, eax
		for:
		cmp ecx, 1
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
			jle return
				dec ecx
			mul ecx
			jmp for2
			return:

		mov edx,0
			div ebx
			mul m

			third:
	}
}
int calculate2(int a, int b, int c) {
	_asm {
		mov eax,a
		sub eax,b
		mov ecx,eax
		for:
		cmp ecx,1
			jle skip
			dec ecx
			mul ecx
			jmp for

			skip:
			mov ebx, eax
			mov eax,a
			mul b
			mov ecx,eax
			for2:
		cmp ecx, 1
			jle second
			dec ecx
			mul ecx
			jmp for2

			second:
		mov edx,0
			div ebx
			mul c
			return:
	}
}
int isTriangleReal(int a, int b, int c) {
	_asm {
		mov eax,0
		mov ebx,a
		add ebx,b
		cmp ebx,c
		jle skip
		mov ebx, c
		add ebx,b
		cmp ebx,a
		jle skip
		mov ebx,a
		add ebx,c
		cmp ebx,b
		jle skip
		mov eax,1
		skip:
	}
}
void findAllOddNumbers(int n) {
	_asm {
		mov ecx,n
		for:
		cmp ecx,1
			jle skip
			sub ecx,2
			jmp for

			skip:
			cmp ecx,1
			jne first
			for2:
			cmp ecx,n
			jge return
		mov [arr+4*ecx],ecx
			add ecx,2
			jmp for2

				first:
				mov eax,n
				sub eax,1
				for3:
				cmp ecx, eax
				jle return
				mov[arr + 4 * ecx], ecx
				add ecx, 2
				jmp for3

		return:
	}
	for (int i = 0; i < 25; i++) {
		cout << arr[i] << endl;
	}
}
void findAllEvenNumbers(int n) {
	_asm {
		mov ecx,n
		for:
		cmp ecx,1
			jle skip
			sub ecx,2
			jmp for
			skip:

			cmp ecx,0
			je first
			add ecx,1
			for3:
			cmp ecx,n
			jge return
			mov [arr+4*ecx],ecx
			add ecx,2
			jmp for3


		first:
		for2:
			cmp ecx,n
			jge return
			mov[arr+4*ecx],ecx
			add ecx,2
			jmp for2
			return:
	}
	for (int i = 0; i < 10; i++) {
		cout << arr[i] << endl;
	}
}
void findAllOddNumbers2(int n) {
	_asm {
		mov eax,1
		mov ecx,0
		for:
		cmp eax,n
			jge return
			mov [arr+4*ecx],eax
			add eax,2
			inc ecx
			jmp for
			return:
	}
	for (int i = 0; i < 25; i++) {
		cout << arr[i] << endl;
	}
}
void findAllEvenNumbers2(int n) {
	_asm {
		mov ecx,0
		mov eax,0
		for:
		cmp eax,n
			jge return
			mov [arr+4*ecx],eax
		    add eax,2
			inc ecx
			jmp for

		return:
	}

	for (int i = 0; i < 25; i++) {
		cout << arr[i] << endl;
	}
}



int main() {
	//cout << add(5, 2) << endl;
	//cout << power(5) << endl;
	//cout << abss(5) << endl<<abss(-3)<<endl<<abss(0)<<endl;
	//cout << square_perimeter(4)<<endl;
	//cout << triangle_perimeter(4,6,2)<<endl;
	//cout << rectangle_perimeter(4,6)<<endl;
	//cout << rectangle_area(4,6)<<endl;
	//positiveSumAndCount(1,- 4,- 6);
	//negativeAndSum(1,- 4,- 6);
	//cout << avg(6, 12, 2, -4) << endl;
	//cout << min_number(-4, 1, -3)<<endl;
	//cout << max_number(-4, -1, 3,-11)<<endl;
	//cout << substract(4, -1)<<endl;
	//cout << multiply(4, -1)<<endl;
	//cout << avg_int(4, -1,6)<<endl;
	//cout << avg_short(4, -1,6)<<endl;
	//cout << sgn(0)<<endl;
	//cout << perimeter_of_rectangle(4,3)<<endl;
	//cout << area_of_rectangle(4,3)<<endl;
	//cout << perimeter_of_square(4) << endl;
	//cout << area_of_square(4) << endl;
	//cout << perimeter_of_triangle(4,5,6) << endl;
	//cout << perimeter_of_triangle2(4) << endl;
	//cout << perimeter_of_triangle3(4,2) << endl;
	//cout << perimeter_of_triangle4(4,2) << endl;
	//cout << area_of_cube(5) << endl;
	//cout << compare(4, 3)<<endl<<compare(3,4)<<endl<<compare(7,7)<<endl;
	//cout << pzn(4)<<endl<<pzn(-1)<<endl<<pzn(0)<<endl;
	//cout << power(2,3) << endl;
	//cout << positive(-2,3,5) << endl;
	//cout << min3(2,3,5) << endl;
	//cout << factorial(5) << endl;
	//step(2);
	//quadrat();
	//cout << fibSum(6) << endl;
	//fibonacci();
	//countdown();
	//counter();
	//cout<<min_element()<<endl;
	//cout << grade(2, 6) << endl << grade(6, 3) << endl;
	//cout << max_element() << endl;
	//cout << average(21, -7, 4) << endl;
	//cout << example(5, 2) << endl;
	//cout << evenOrOdd(11) << endl;
	//cout << oddAndSum(5) << endl;
	//evenNumbers(10);
	//cout << cmp(-4, 6, 12) << endl;
	//fib( 6);
	//cout << prime_number(17) << endl;
	//cout << calculate(3,6,2) << endl;
	//cout << calculate2(6,2,3) << endl;
	//cout << isTriangleReal(3, 4, 6) << endl << isTriangleReal(1, 11, 2)<<endl<<isTriangleReal(2,3,7)<<endl<<isTriangleReal(12,5,2)<<endl;
	//findAllOddNumbers(12);
	//findAllOddNumbers2(50);
	//findAllEvenNumbers(11);
	findAllEvenNumbers2(50);


}