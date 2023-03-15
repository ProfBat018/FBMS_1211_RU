import React from "react";

class Button extends React.Component {
    constructor(props) {
        super(props);  // делегирование к-ра на базовый класс
        this.state = {class: "off", label: this.props.children};
        this.press = this.press.bind(this);

        console.log("constructor");
    }
    static getDerivedStateFromProps(props, state) {
        console.log("getDerivedStateFromProps()");
        return null;
    }
    componentDidMount(){ // компонент вставлен
        console.log("componentDidMount()");
    }
    componentWillUnmount(){  // компонент будет вытащен
        console.log("componentWillUnmount()");
    }
    shouldComponentUpdate(){ // компонент должен обновится
        console.log("shouldComponentUpdate()");
        return true;
    }
    getSnapshotBeforeUpdate(prevProps, prevState) { // сохранение перед обновлением
        console.log("getSnapshotBeforeUpdate()");
        return null;
    }
    componentDidUpdate(){ // компонент обновлен
        console.log("componentDidUpdate()");
    }
    press(){
        var className = (this.state.class==="off")?"on":"off";
        this.setState({class: className});
    }
    render() { // return функцианального компонента - это метод render()
        console.log("render()");
        return <button onClick={this.press} className={this.state.class}>{this.state.label}</button>;
    }
}
export default Button;