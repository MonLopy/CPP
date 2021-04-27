#include<iostream>
#include<bitset>
#include<string>
#include <sstream>
#include<cmath>
using namespace std;
int main() {
	cout << "\t\t\t\t\t\t    IP address" << endl;
asd:
	char choice;
	cout << "Convert:" << endl;
	cout << "1)From ipv4(bin-dec-hex) PRESS \"1\"" << endl;
	cout << "2)From ipv6(hex-bin-dec) PRESS \"2\"" << endl;
	cout << "3)From ipv4 to ipv6 PRESS \"3\"" << endl;
	cout << "You choose: _\b";
	cin >> choice;
	switch (choice)
	{

	case '1':
	{
		int ip1, ip2, ip3, ip4;
	tryAgain:
		cout << "first three" << endl;
		cin >> ip1;
		if (ip1 > 255 || ip1 < 0) {
			cerr << "IP numbers are amoung 0-255. You write more. Try again:  " << endl;
			goto tryAgain;
		}
	tryMore:
		cout << "second three" << endl;
		cin >> ip2;
		if (ip2 > 255 || ip2 < 0) {
			cerr << "IP numbers are amoung 0-255. You write more. Try again:  " << endl;
			goto tryMore;
		}
	tryToo:
		cout << "third three" << endl;
		cin >> ip3;
		if (ip3 > 255 || ip3 < 0) {
			cerr << "IP numbers are amoung 0-255. You write more. Try again:  " << endl;
			goto tryToo;
		}
	tryHard:
		cout << "fourth three" << endl;
		cin >> ip4;
		if (ip4 > 255 || ip4 < 0) {
			cerr << "IP numbers are amoung 0-255. You write more. Try again:  " << endl;
			goto tryHard;
		}
		cout << "from  Decimal to Binary:   " << endl;
		cout << bitset<8>(ip1) << "." << bitset<8>(ip2) << "." << bitset<8>(ip3) << "." << bitset<8>(ip4);
		cout << endl;
		bitset<10> set(ip1);
		bitset<10> tes(ip2);
		bitset<10> ets(ip3);
		bitset<10> est(ip4);
		cout << "From Binary to Heximal:   " << endl;
		cout << hex << set.to_ulong() << "." << tes.to_ulong() << "." << ets.to_ulong() << "." << est.to_ulong() << endl;
		break;
	}

	case'2':
	{
		cout << "Enter your ipv6 (You can Use From A-F and 0-9: " << endl;
		string s = " ", d = " ", f = " ", g = " ", h = " ", j = " ", k = " ", l = " ";
		cin >> s >> d >> f >> g >> h >> j >> k >> l;
		if (s == "::") { s = "0000"; }
		if (d == "::") { s = "0000"; }
		if (f == "::") { s = "0000"; }
		if (g == "::") { s = "0000"; }
		if (h == "::") { s = "0000"; }
		if (j == "::") { s = "0000"; }
		if (k == "::") { s = "0000"; }
		if (l == "::") { s = "0000"; }

		stringstream res, q, w, e, r, t, y, u;
		res << hex << s;
		q << hex << d;
		w << hex << f;
		e << hex << g;
		r << hex << h;
		t << hex << j;
		y << hex << k;
		u << hex << l;
		unsigned n, z, x, c, v, b, m, a;
		res >> n;
		q >> z;
		w >> x;
		e >> c;
		r >> v;
		t >> b;
		y >> m;
		u >> a;
		bitset<16> bq(n);
		bitset<16> be(z);
		bitset<16> bo(x);
		bitset<16> bi(c);
		bitset<16> bu(v);
		bitset<16> ba(b);
		bitset<16> bn(m);
		bitset<16> bm(a);
		cout << "\t\t\t\t\t\t From Heximal to Binary " << endl;
		cout << bq.to_string() << ":" << be.to_string() << ":" << bo.to_string() << ":" << bi.to_string()
			<< ":" << bu.to_string() << ":" << ba.to_string() << ":" << bn.to_string() << ":" << bm.to_string() << endl;
		cout << "\t\t\t\t\t\t From Binary to Decimal " << endl;
		cout << bq.to_ulong() << "." << be.to_ulong() << "." << bo.to_ulong() << "." << bi.to_ulong()
			<< "." << bu.to_ulong() << "." << ba.to_ulong() << "." << bn.to_ulong() << "." << bm.to_ulong() << endl;
		break;
	}
	case '3':
	{
		int ip1, ip2, ip3, ip4;
	qq:
		cout << "first three" << endl;
		cin >> ip1;
		if (ip1 > 255 || ip1 < 0) {
			cerr << "IP numbers are amoung 0-255. You write more. Try again:  " << endl;
			goto qq;
		}
	ww:
		cout << "second three" << endl;
		cin >> ip2;
		if (ip2 > 255 || ip2 < 0) {
			cerr << "IP numbers are amoung 0-255. You write more. Try again:  " << endl;
			goto ww;
		}
	ee:
		cout << "third three" << endl;
		cin >> ip3;
		if (ip3 > 255 || ip3 < 0) {
			cerr << "IP numbers are amoung 0-255. You write more. Try again:  " << endl;
			goto ee;
		}
	rr:
		cout << "fourth three" << endl;
		cin >> ip4;
		if (ip4 > 255 || ip4 < 0) {
			cerr << "IP numbers are amoung 0-255. You write more. Try again:  " << endl;
			goto rr;
		}
		cout << "from  Decimal to Binary:   " << endl;
		cout << bitset<8>(ip1) << "." << bitset<8>(ip2) << "." << bitset<8>(ip3) << "." << bitset<8>(ip4);
		cout << endl;
		bitset<10> set(ip1);
		bitset<10> tes(ip2);
		bitset<10> ets(ip3);
		bitset<10> est(ip4);
		cout << "ipv4 to ivp6:   " << endl;
		cout << hex << "::ffff." << set.to_ulong() << tes.to_ulong() << "." << ets.to_ulong() << est.to_ulong() << endl;
		break;
	}
	default:
		cerr << "You enter wrong number. Try again!" << endl;
		goto asd;
	}
	cout << "DONE";
	cin.get();
	return 0;
}
