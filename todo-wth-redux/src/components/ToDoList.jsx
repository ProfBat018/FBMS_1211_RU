import { useSelector } from 'react-redux';
import ToDoItem from './ToDoItem';

// useSelector - нужен для получения данных из хранилища

const ToDoList = () => {
    const todos = useSelector(state => state.todosStore.todos);
    return (
        <ul>
            {todos.map((todo) => (
                <ToDoItem
                    key={todo.id}
                    {...todo}
                />
            ))}
        </ul>
    );
};

export default ToDoList;