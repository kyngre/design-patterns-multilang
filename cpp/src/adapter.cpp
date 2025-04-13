// adapter.cpp
#include <iostream>
#include <string>

// 내부 클래스 (Target)
class InternalClass {
public:
    virtual std::string fetch() {
        return "get user info";
    }
    virtual ~InternalClass() = default;
};

// 외부 클래스 (Adaptee)
class ExternalClass {
public:
    std::string search() {
        return "get user info";
    }
};

// 어댑터 클래스
class Adapter : public InternalClass {
private:
    ExternalClass* external;

public:
    Adapter(ExternalClass* external) : external(external) {}

    std::string fetch() override {
        return external->search();
    }
};

// 테스트 코드
int main() {
    InternalClass* internal = new InternalClass();
    std::cout << "Internal class: " << internal->fetch() << std::endl;

    ExternalClass* external = new ExternalClass();
    std::cout << "External class: " << external->search() << std::endl;

    InternalClass* adapter = new Adapter(external);
    std::cout << "Adapter: " << adapter->fetch() << std::endl;

    delete internal;
    delete external;
    delete adapter;

    return 0;
}