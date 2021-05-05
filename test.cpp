#include <iostream>     
#include <vector>       
#include <algorithm>
#include <cctype> 
#include<regex>
#include<string>

using namespace std;
int main() {
    vector<string> result;
    string input_data;
    //input
    getline(cin, input_data);
    //remove dots and etc.
    input_data.erase(std::remove(input_data.begin(), input_data.end(), ','),  input_data.end());
    input_data.erase(std::remove(input_data.begin(), input_data.end(), '.'), input_data.end());
    input_data.erase(std::remove(input_data.begin(), input_data.end(), '-'), input_data.end());
    input_data.erase(std::remove(input_data.begin(), input_data.end(), ':'), input_data.end());

    //to_lower
    transform(input_data.begin(), input_data.end(), input_data.begin(), ::tolower);
    result.push_back((input_data.substr(0, input_data.find(' '))));
    //regex
    static const std::regex rdelim{ " " };
    vector<string> strPairs{
            sregex_token_iterator(input_data.begin(), input_data.end(), rdelim, -1),
            sregex_token_iterator()
    };
    //unique data
    for (int i = 1; i < strPairs.size(); ++i) {

        int flag = 1;
        for (int j = 0; j < i; ++j) {
            if (strPairs[j] == strPairs[i]) {
                flag = 0;
                break;
            }
        }
        if (flag)
            result.push_back(strPairs[i]);
    }
    cout <<"Unique:";
    for (int j = 0; j < result.size(); j++) {
        cout << result[j]<<' ';
    }
    cout <<'\n'<<"Size: "<< result.size();
    return 0;
}
