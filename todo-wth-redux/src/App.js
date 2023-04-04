import {useState} from 'react';
import {useDispatch} from 'react-redux';
import {addTodo} from './store/toDoSlice';
import Input from './components/Input';
import ToDoList from './components/ToDoList';

import './App.css';

// redux - это библиотека, которая позволяет управлять состоянием приложения.
// redux toolkit - это набор инструментов, которые позволяют упростить работу с redux.

function App() {
    const [text, setText] = useState('');
    // useDispatch - это хук, который позволяет получить доступ к методу dispatch из store.
    const dispatch = useDispatch();

    const handleAction = () => {
        if (text.trim().length) {
            dispatch(addTodo({text}));
            setText('');
        }
    }

    return (
        <div className='App'>
            <Input
                value={text}
                updateText={setText}
                handleAction={handleAction}
            />
            <ToDoList/>
        </div>
    );
}

export default App;