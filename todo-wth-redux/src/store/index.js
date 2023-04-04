import { configureStore } from '@reduxjs/toolkit';
import todoReducer from './toDoSlice';

// configureStore - это функция, которая принимает объект с настройками и возвращает объект store.
// В нашем случае мы передаем в нее объект с одним свойством reducer, которое содержит объект с нашим редьюсером.
// В результате мы получаем объект store, который содержит методы getState, dispatch, subscribe и replaceReducer.

// Методы getState и dispatch мы уже знаем, а метод subscribe позволяет подписаться на изменения в store.
// Метод replaceReducer позволяет заменить редьюсер, который используется в store.

export default configureStore({
    reducer: {
        todosStore: todoReducer,
    },
});

