import {createSlice} from '@reduxjs/toolkit';

// createSlice - это функция, которая принимает объект с именем и начальным состоянием, а также объект с редьюсерами.
// Возвращает объект с редьюсером и объектом с действиями, которые можно использовать в компонентах.
// Все действия автоматически добавляются в редьюсер.
// Slice - это набор редьюсеров и действий, которые можно использовать в компонентах.
// Редьюсер - это функция, которая принимает состояние и действие, а затем возвращает новое состояние.
// payload - это объект, который передается в действие и хранит данные, которые нужно обработать в редьюсере.
// Если перевести на русский язык, то payload - это груз, который нужно доставить.
// В данном случае, в payload передается объект с текстом задачи.
// Для того, чтобы получить доступ к payload, нужно написать action.payload.text.


const toDoSlice = createSlice({
    name: 'todos', initialState: {
        todos: [],
    }, reducers: {
        addTodo(state, action) {
            state.todos.push({
                id: new Date().toISOString(), // new Date().toISOString() - это уникальный идентификатор.
                text: action.payload.text, // action.payload - это объект, который передается в действие.
                completed: false, // completed - это свойство, которое показывает, выполнена ли задача.
            });
        }, toggleComplete(state, action) {
            // find - ищет в массиве объект с id, который передается в действие.
            const toggledTodo = state.todos.find(todo => todo.id === action.payload.id);
            // toggleToDo - это ссылка на объект, который нашли в массиве.
            // если поменять toggleToDo, то state обновится.
            toggledTodo.completed = !toggledTodo.completed; // тут меняем свойство completed на противоположное.
        }, removeTodo(state, action) {
            // удаляем из массива объект с id, который передается в действие.
            state.todos = state.todos.filter(todo => todo.id !== action.payload.id);
        }
    },
});

// Экспортируем объект с действиями, чтобы можно было использовать их в компонентах.
export const
    {
        addTodo,
        toggleComplete,
        removeTodo
    } = toDoSlice.actions;

// Экспортируем редьюсер, чтобы можно было использовать его в store.
export default toDoSlice.reducer;