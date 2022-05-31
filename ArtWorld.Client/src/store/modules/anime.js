import axios from '@/plugins/axios'

export default {

    state: {
        anime: null,
    },

    getters: {
        anime: state => {
            return state.anime
        }
    },

    mutations: {
        SET_ANIME(state, payload) {
            state.anime = payload.anime
        }
    },

    actions: {
        async login({commit}, data) {
            return await axios.post('/login', data)
                .then(res => {
                    commit('SET_USER', res.data)
                })
                .catch(err => {
                    console.log(err.message)
                })
        },
    }
}