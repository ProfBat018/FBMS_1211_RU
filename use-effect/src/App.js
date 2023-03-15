import logo from './logo.svg';
import {useState, useEffect} from "react";
import './App.css';
import axios from "axios";

function App() {
    //// Второй пример
    const [count, setCount] = useState(0);
    const [test, setTest] = useState(0);

    useEffect(() => {
        console.log(`useEffect`);
        axios.get(`http://localhost:3001/users/`).then((res) => {
            console.log(res.data);
        });
    }, [count, test]);

    return (
        <div className="App">
            <h1>You clicked {count} times...</h1>
            <button onClick={() => setCount(count + 1)}>Fetch</button>
            <button onClick={() => setTest(test + 1)}>test</button>
        </div>
    );

    //// Первый пример
    // const [count, setCount] = useState(0);
    //
    // useEffect(() => {
    //     console.log(`useEffected reacted`);
    //     document.title = `Clicked: ${count}`;
    // });
    //
    //
    //
    // return (
    //     <div className="App">
    //         <h1>You clicked {count} times...</h1>
    //         <button onClick={() => {setCount(count + 1)}}>Click</button>
    //     </div>
    // );
}

export default App;
