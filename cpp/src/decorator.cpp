// decorator.cpp
#include <iostream>

// 기본 컴포넌트
class Coffee {
public:
    virtual int cost() {
        return 5;
    }
    virtual ~Coffee() = default;
};

// 데코레이터 기본 클래스
class CoffeeDecorator : public Coffee {
protected:
    Coffee* coffee;

public:
    CoffeeDecorator(Coffee* coffee) : coffee(coffee) {}
    
    int cost() override {
        return coffee->cost();
    }
    
    virtual ~CoffeeDecorator() {
        // 상위 데코레이터가 하위 컴포넌트를 관리
        // 실제 애플리케이션에서는 메모리 관리를 위한 스마트 포인터 사용이 권장됨
    }
};

// 우유 데코레이터
class MilkDecorator : public CoffeeDecorator {
public:
    MilkDecorator(Coffee* coffee) : CoffeeDecorator(coffee) {}
    
    int cost() override {
        return coffee->cost() + 2;
    }
};

// 설탕 데코레이터
class SugarDecorator : public CoffeeDecorator {
public:
    SugarDecorator(Coffee* coffee) : CoffeeDecorator(coffee) {}
    
    int cost() override {
        return coffee->cost() + 1;
    }
};

// 테스트 코드
int main() {
    Coffee* coffee = new Coffee();
    std::cout << "Coffee: " << coffee->cost() << std::endl;  // 5
    
    Coffee* coffeeWithMilk = new MilkDecorator(coffee);
    std::cout << "Coffee with milk: " << coffeeWithMilk->cost() << std::endl;  // 7
    
    Coffee* coffeeWithSugar = new SugarDecorator(coffee);
    std::cout << "Coffee with sugar: " << coffeeWithSugar->cost() << std::endl;  // 6
    
    Coffee* coffeeWithMilkAndSugar = new SugarDecorator(coffeeWithMilk);
    std::cout << "Coffee with milk and sugar: " << coffeeWithMilkAndSugar->cost() << std::endl;  // 8
    
    // 메모리 해제 순서 주의
    delete coffeeWithMilkAndSugar;
    delete coffeeWithSugar;
    delete coffeeWithMilk;
    delete coffee;
    
    return 0;
}