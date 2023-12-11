# Decorator Pattern

Decorator Pattern (Dekoratör Deseni), Nesne Yönelimli Programlama'nın (OOP) tasarım desenlerinden biridir. Bu desen, bir nesnenin davranışını dinamik olarak genişletmeyi ve nesneyi yeni özelliklerle süslemeyi sağlar. Decorator Pattern, mirasın alternatifi olarak kullanılarak, kodun daha esnek ve sürdürülebilir olmasına katkı sağlar.

## Temel Kavramlar

### Component (Bileşen):
Temel davranışı tanımlayan arayüzdür veya soyut sınıftır. Decorator Pattern'deki tüm bileşenler bu arayüzü veya sınıfı uygularlar.

### ConcreteComponent (Somut Bileşen):
Temel davranışı gerçekleştiren ve Component arayüzünü uygulayan sınıftır. Decorator, genellikle bu sınıfı sarmalar ve genişletir.

### Decorator (Dekoratör):
Component arayüzünü uygular ve ConcreteComponent'i sarmak için kullanılır. Bu, alt sınıfların nesnenin davranışını genişletmelerine izin verir.

### ConcreteDecorator (Somut Dekoratör):
Decorator'ı genişleten ve yeni davranış veya özellik ekleyen sınıftır. Birden çok ConcreteDecorator bir araya getirilebilir.

## Nasıl Çalışır:
### Temel Bileşen:
Bir nesnenin temel davranışını tanımlayan ConcreteComponent sınıfını oluşturun. Bu sınıf, Component arayüzünü uygular.

```typescript
interface Component {
    operation(): void;
}

class ConcreteComponent implements Component {
    operation(): void {
        console.log("ConcreteComponent operation");
    }
}
```

### Decorator:
Component arayüzünü uygulayan ve genellikle bir ConcreteComponent örneğini içeren Decorator sınıfını oluşturun.

```typescript
class Decorator implements Component {
    protected component: Component;

    constructor(component: Component) {
        this.component = component;
    }

    operation(): void {
        this.component.operation();
    }
}
```

### Somut Dekoratörler:
Decorator sınıfını genişleten ve yeni davranış ekleyen ConcreteDecorator sınıflarını oluşturun.

```typescript
class ConcreteDecoratorA extends Decorator {
    operation(): void {
        super.operation();
        console.log("ConcreteDecoratorA operation");
    }
}

class ConcreteDecoratorB extends Decorator {
    operation(): void {
        super.operation();
        console.log("ConcreteDecoratorB operation");
    }
}
```

### Kullanım:
Şimdi, isteğe bağlı olarak ConcreteDecorator sınıflarını birleştirerek, nesnenin davranışını dinamik olarak genişletebilirsiniz.

```typescript
const baseComponent: Component = new ConcreteComponent();
const decoratedA: Component = new ConcreteDecoratorA(baseComponent);
const decoratedB: Component = new ConcreteDecoratorB(decoratedA);

decoratedB.operation();
```

Bu kod örneğinde, baseComponent ile başlayarak, ConcreteDecoratorA ve ConcreteDecoratorB sınıfları kullanılarak nesnenin davranışı dinamik olarak genişletilmektedir. Bu sayede, yeni özellikler eklemek veya mevcut davranışı değiştirmek istediğinizde, yeni bir dekoratör ekleyebilir veya mevcut dekoratörleri değiştirebilirsiniz.

Decorator Pattern, Open/Closed prensibini destekleyerek kodun açılmaya (open) ve değişmemeye (closed) olanak tanır. Yeni davranışlar eklemek, mevcutları değiştirmek için sınıfların açılmasına gerek kalmadan, dekoratörlerle genişletme yapılabilir.