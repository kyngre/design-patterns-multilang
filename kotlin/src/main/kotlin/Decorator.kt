// Decorator.kt
package designpatterns

// 기본 컴포넌트
open class Coffee {
    open fun cost(): Int {
        return 5
    }
}

// 데코레이터 기본 클래스
abstract class CoffeeDecorator(protected val coffee: Coffee) : Coffee() {
    override fun cost(): Int {
        return coffee.cost()
    }
}

// 우유 데코레이터
class MilkDecorator(coffee: Coffee) : CoffeeDecorator(coffee) {
    override fun cost(): Int {
        return coffee.cost() + 2
    }
}

// 설탕 데코레이터
class SugarDecorator(coffee: Coffee) : CoffeeDecorator(coffee) {
    override fun cost(): Int {
        return coffee.cost() + 1
    }
}

// 테스트 함수
fun testDecorator() {
    val coffee = Coffee()
    println("Coffee: ${coffee.cost()}")  // 5

    val coffeeWithMilk = MilkDecorator(coffee)
    println("Coffee with milk: ${coffeeWithMilk.cost()}")  // 7

    val coffeeWithSugar = SugarDecorator(coffee)
    println("Coffee with sugar: ${coffeeWithSugar.cost()}")  // 6

    val coffeeWithMilkAndSugar = SugarDecorator(coffeeWithMilk)
    println("Coffee with milk and sugar: ${coffeeWithMilkAndSugar.cost()}")  // 8
}