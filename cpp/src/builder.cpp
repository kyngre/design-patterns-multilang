// builder.cpp
#include <iostream>
#include <string>

// 계산기 클래스 (메소드 체이닝)
class Calculator {
private:
    double result;

public:
    Calculator() : result(0) {}

    Calculator& add(double value) {
        result += value;
        return *this;
    }

    Calculator& subtract(double value) {
        result -= value;
        return *this;
    }

    Calculator& multiply(double value) {
        result *= value;
        return *this;
    }

    Calculator& divide(double value) {
        if (value != 0) {
            result /= value;
        }
        return *this;
    }

    double getResult() const {
        return result;
    }
};

// Person 클래스 (빌더 패턴 + 메소드 체이닝)
class Person {
public:
    std::string name;
    int age;
    std::string address;
    
    void display() const {
        std::cout << "Name: " << name << ", Age: " << age << ", Address: " << address << std::endl;
    }
};

class PersonBuilder {
private:
    Person person;

public:
    PersonBuilder& withName(const std::string& name) {
        person.name = name;
        return *this;
    }

    PersonBuilder& withAge(int age) {
        person.age = age;
        return *this;
    }

    PersonBuilder& withAddress(const std::string& address) {
        person.address = address;
        return *this;
    }

    Person build() const {
        return person;
    }
};

// 테스트 코드
int main() {
    // 계산기 예제 - 메소드 체이닝
    Calculator calc;
    double result = calc.add(5).multiply(2).subtract(3).divide(2).getResult();
    std::cout << "Calculator result: " << result << std::endl;

    // Person 빌더 예제
    Person person = PersonBuilder()
        .withName("홍길동")
        .withAge(20)
        .withAddress("양산시 부산대학로")
        .build();
    
    person.display();
    
    return 0;
}