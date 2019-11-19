#include <iostream>
#include <math.h>
#include <string.h>
#include <sstream>

using namespace std;

int toInt(string str) {
	stringstream ss(str);
	int val;
	ss >> val;
	return val;
}

int bigger(string num_1, string num_2) {
	// This function returns which number is greater from the two, or if they are equal
	if (num_1.size() > num_2.size())
		return -1;
	if (num_2.size() > num_1.size())
		return 1;
	for (int i = 0; i < num_1.size(); i++) {
		if ((int)(num_1[i] - 48) > (int)(num_2[i] - 48))
			return -1;
		if ((int)(num_2[i] - 48) > (int)(num_1[i] - 48))
			return 1;
	}
	return 0;
}

string sum(string num_1, string num_2) {
	char first = num_1[0], second = num_2[0];
	bool both_negative = false;
	bool one_negative = false;
	if (first == '-') {
		one_negative = true;
		num_1 = num_1.substr(1);
	}
	if (second == '-') {
		one_negative = true;
		if (first == '-')
			both_negative = true;
		num_2 = num_2.substr(1);
	}

	int idx_1 = num_1.size() - 1, idx_2 = num_2.size() - 1;
	// val_1 represents the current digit from the first number, val_2 for the second, val_3 is a carry if the 
	// sum of the first two > 10
	int val_1 = 0, val_2 = 0, val_3 = 0;
	string final_output = "";
	// determine which number is greater, which is useful if either of the numbers is negative
	int larger = bigger(num_1, num_2);

	while (true) {
		if (idx_1 < 0) {
			// if we have added every digit for the first number
			// assign val_1 to zero and take the other, if the other is still there
			if (idx_2 < 0) {
				// if every digit from the second number has also been added, check if there is any carry remaining
				if (val_3 != 0)
					final_output += to_string(val_3);
				break;
			}
			val_1 = 0;
		}
		else {
			string str; str += num_1[idx_1];
			stringstream ss(str);
			ss >> val_1;
		}
		if (idx_2 < 0) {
			// take the other, if the other is still there
			if (idx_1 < 0) {
				if (val_3 != 0)
					final_output += to_string(val_3);
				break;
			}
			val_2 = 0;
		}
		else {
			string str; str += num_2[idx_2];
			val_2 = toInt(str);
		}
		int sum = 0;
		if (both_negative || !one_negative) // simple addition
			sum = val_1 + val_2 + val_3;
		else if (!both_negative) {
			if (larger == 0)
				return 0;
			if (larger == -1) {
				// num_1 > num_2
				sum = val_1 - val_2;
				if (sum < 0) {
					// borrow from the left
					int temp_idx = idx_1 - 1;
					sum = val_1 + 10 - val_2;
					while ((int)(num_1[temp_idx] - 48) == 0) {
						num_1[temp_idx] = '9';
						temp_idx--;
					}
					int deducted_val = (int)(num_1[temp_idx] - 48) - 1;
					num_1[temp_idx] = (char)(deducted_val + 48);
				}
			}
			else if (larger == 1) {
				// num_2 > num_1
				sum = val_2 - val_1;
				if (sum < 0) {
					int temp_idx = idx_2 - 1;
					sum = val_2 + 10 - val_1;
					while ((int)(num_2[temp_idx] - 48) == 0) {
						num_2[temp_idx] = '9';
						temp_idx--;
					}
					int deducted_val = (int)(num_2[temp_idx] - 48) - 1;
					num_2[temp_idx] = (char)(deducted_val + 48);
				}
			}
		}
		string sum_str = to_string(sum);
		if (sum_str.size() > 1 && sum_str[0] != '-') {
			int len = sum_str.size() - 1;
			val_3 = toInt(sum_str.substr(0, len));
			string final_val = sum_str.substr(len);
			final_output += final_val;
		}
		else if (sum_str[0] != '-') {
			val_3 = 0;
			string str; str += sum_str[0];
			final_output += str;
		}
		else {
			final_output += sum_str.substr(1);
			final_output += "-";
			break;
		}
		idx_1--, idx_2--;
	}
	string res;
	for (int i = final_output.size() - 1; i >= 0; i--)
		res += final_output[i];
	// remove all trailing zeros
	int i = 0;
	while (i < res.size() - 1) {
		if (res[i] == '0') {
			res = res.substr(i + 1);
			i = 0;
		}
		else
			break;
	}
	if (both_negative)
		return "-" + res;
	if (one_negative) {
		if ((first == '-' && larger == -1) || (second == '-' && larger == 1))
			return "-" + res;
	}
	return res;
}

int main() {
	string a, b;
	cout << "Enter a: " << endl;
	cin >> a;
	cout << "Enter b: " << endl;
	cin >> b;
	string output = sum(a, b);
	cout << output << endl;
	cout << endl;
	cin.ignore();
}