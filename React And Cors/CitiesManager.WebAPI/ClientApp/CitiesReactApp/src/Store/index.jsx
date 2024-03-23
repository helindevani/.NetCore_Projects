import { configureStore, createSlice, createAsyncThunk } from '@reduxjs/toolkit';

const apiUrl = 'http://localhost:5205/api/cities';

export const fetchCities = createAsyncThunk(
    "city/fetchCities", // Corrected action type
    async () => {
        const response = await fetch(apiUrl);
        if (!response.ok) {
            throw new Error('Failed to fetch cities');
        }
        const data = await response.json();
        return data;
    }
);

export const addCity = createAsyncThunk(
    'city/addCity',
    async ({ cityId, cityName }) => {
        const response = await fetch(apiUrl, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify({ cityId: cityId, cityName: cityName }),
        });
        if (!response.ok) {
            throw new Error('Failed to create city');
        }
        const data = await response.json();
        return data;
    }
);

export const updateCity = createAsyncThunk(
    'city/updateCity',
    async ({ cityId, cityName }) => {
        const response = await fetch(`${apiUrl}/${cityId}`, {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify({cityId, cityName }),
        });
        console.log(response);
        if (!response.ok) {
            throw new Error('Failed to update city');
        }

        const data = await response.json();
       
        return { data };
    }
);

export const deleteCity = createAsyncThunk(
    'city/deleteCity',
    async (cityId) => {
        const response = await fetch(`${apiUrl}/${cityId}`, {
            method: 'DELETE',
        });
        if (!response.ok) {
            throw new Error('Failed to delete city');
        }
        return cityId;
    }
);


const citySlice = createSlice({
    name: 'city',
    initialState: {
        cities : [],
    },
    reducers: {},
    extraReducers: (builder) =>
    {
        builder
            .addCase(fetchCities.fulfilled, (state, action) => {   
                state.cities = action.payload;
            })
            .addCase(addCity.fulfilled, (state, action) => {
                state.cities.push(action.payload);
            })
            .addCase(updateCity.fulfilled, (state, action) => {
                const index = state.cities.findIndex(city => city.cityId === action.payload.data.cityId);
                if (index !== -1) {
                    state.cities[index] = action.payload.data;
                }
            })
            .addCase(deleteCity.fulfilled, (state, action) => {
                state.cities = state.cities.filter(city => city.cityId !== action.payload);
            })
    }
});

const store = configureStore({
    reducer: {
        city: citySlice.reducer,
    },
});
export default store;

