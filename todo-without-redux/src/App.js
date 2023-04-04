import './App.css';
import {useEffect, useState} from "react";
import ToDoList from "./components/ToDoList";
import Input from "./components/Input";

function App() {
    const [todos, setTodos] = useState([]);
    const [text, setText] = useState('');

    const addTodo = () => {
        if (text.trim().length) {
            setTodos([...todos, {
                id: new Date().toISOString(),
                text,
                completed: false
            }]);
            setText('');
        }
    }

    const removeTodo = (toDoId) => {
        setTodos((todos.filter(todo => todo.id !== toDoId)));
    };

    const toggleToDo = (toDoID) => {
        setTodos(todos.map(
            todo => {
                if (todo.id !== toDoID) return todo;
                return {
                    ...todo,
                    completed: !todo.completed
                }
            }
        ));
    }
    useEffect(() => {
        console.log(todos);
    }, [todos]);

    return (
        <div className="App">
            <Input text={text} handleText={setText} handleAdd={addTodo} />
           <ToDoList todos={todos} toggleToDo={toggleToDo} removeToDo={removeTodo} />
        </div>
    );
}

export default App;
