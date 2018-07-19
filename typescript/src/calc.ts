
export default class Calculator
{
    public Add(a:number, b:number) : number {
        return a + b;
    }

    public Subtract(a:number, b:number) : number {
        return a - b;
    }

    public Multiply(a:number, b:number) : number {
        return a * b;
    }

    public Divide(a:number, b:number) : number {
        if (b === 0) {
            throw new Error('Cannot divide by zero');
        }
        return a / b;
    }
}
