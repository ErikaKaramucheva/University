#include <iostream>
using namespace std; 

int main()
{
	/* //Напише конзолна програма, която чете оценка (цяло число), въведена от потребителя, и
//отпечатва: Excellent!ако оценката е 5 или по - висока.
	int grade;
	cout << "Enter a grade:\n";
	cin >> grade;
	if (grade < 2 || grade > 6) {
		cout << "Error!" << endl;
	} if (grade < 3) {
		cout << "Fail";
	} else if (grade < 4) {
		cout << "Average";
	}
	else if (grade < 5) {
		cout << "Good";
	}
	else {
		cout << "Excellent!";
	}*/

	/*
	//Да се напише програма, която чете две цели числа, въведени от потребителя, и отпечатва по-
	//голямото от двете.
	int a, b;
	cout << "Enter two integers:\n";
	cin >> a >> b;
	if (a == b) {
		cout << a << "=" << b;
	}
	else if (a < b) {
		cout << a << " is less than " << b;
	}
	else {
		cout << a << " is bigger than " << b;
	}*/

	/* //Да се напише програма, която чете цяло число, въведено от потребителя, и печата дали е четно
	//или нечетно.
	int n;
	cout << "Enter a num:\n";
	cin >> n;
	if (n % 2 == 0) {
		cout << n << " is even.";
	}
	else {
		cout << n << " is odd";
	}*/

	/*//Да се напише програма, която чете час и минути от 24-часово денонощие, въведени от
	//потребителя и изчислява колко ще е часът след 15 минути.Резултатът да се отпечата във формат
	//часове : минути.Часовете винаги са между 0 и 23, а минутите винаги са между 0 и 59. Часовете се изписват с една или две
	//цифри. Минутите се изписват винаги с по две цифри, с водеща нула, когато е необходимо.
	int h;
	int min;
	cout << "Enter an hour:\n";
	cin >> h;
	cout << "Enter a minute:\n";
	cin >> min;
	int newMin = min + 15;
	if (h > 23 || min > 59) {
		cout << "Error. Please try again.\n";
		cin >> h >> min;
	}
	if (newMin < 60) {
		cout << "Time is " << h << ":" << newMin;
	}
	else if (newMin > 60 && newMin < 70) {
		cout << "Time is " << h + 1 << ":0" << newMin - 60;
	}
	else  if (newMin > 60) {
		cout << "Time is " << h << ":" << newMin - 60;
	}*/
}
