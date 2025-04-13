// factory.cpp
#include <iostream>
#include <string>
#include <memory>

// 추상 클래스
class Animal {
public:
    virtual std::string speak() = 0;
    virtual ~Animal() = default;
};

// 구체 클래스들
class Dog : public Animal {
public:
    std::string speak() override {
        return "Woof!";
    }
};

class Cat : public Animal {
public:
    std::string speak() override {
        return "Meow!";
    }
};

// 팩토리 클래스
class AnimalFactory {
public:
    std::unique_ptr<Animal> createAnimal(const std::string& animalType) {
        if (animalType == "dog") {
            return std::make_unique<Dog>();
        } else if (animalType == "cat") {
            return std::make_unique<Cat>();
        }
        return nullptr;
    }
};

// 테스트 코드
int main() {
    AnimalFactory factory;
    
    auto dog = factory.createAnimal("dog");
    std::cout << "Dog says: " << dog->speak() << std::endl;
    
    auto cat = factory.createAnimal("cat");
    std::cout << "Cat says: " << cat->speak() << std::endl;
    
    return 0;
}